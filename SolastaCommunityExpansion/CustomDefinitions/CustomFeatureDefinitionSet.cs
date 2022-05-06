﻿using System;
using System.Collections.Generic;
using System.Linq;
using ModKit;
using SolastaCommunityExpansion.Builders;
using SolastaCommunityExpansion.Builders.Features;
using SolastaCommunityExpansion.Models;
using SolastaModApi;
using SolastaModApi.Diagnostics;
using SolastaModApi.Extensions;
using SolastaModApi.Infrastructure;

namespace SolastaCommunityExpansion.CustomDefinitions
{
    public class CustomFeatureDefinitionSet : FeatureDefinition
    {
        private bool _fullSetIsDirty;
        private readonly List<FeatureDefinition> _allFeatureSet = new();
        private Dictionary<int, List<FeatureDefinition>> FeaturesByLevel  = new();
        /**Are level requirements in character levels or class levels?*/
        public bool RequireClassLevels { get; set; }
        public List<int> AllLevels => FeaturesByLevel.Select(e=>e.Key).ToList();

        public List<FeatureDefinition> AllFeatures
        {
            get
            {
                if (_fullSetIsDirty)
                {
                    _allFeatureSet.SetRange(FeaturesByLevel.SelectMany(e => e.Value));
                    _fullSetIsDirty = false;
                }

                return _allFeatureSet;
            }
        }

        private List<FeatureDefinition> GetOrMakeLevelFeatures(int level)
        {
            List<FeatureDefinition> levelFeatures;
            if (!FeaturesByLevel.ContainsKey(level))
            {
                levelFeatures = new List<FeatureDefinition>();
                FeaturesByLevel.Add(level, levelFeatures);
            }
            else
            {
                levelFeatures = FeaturesByLevel[level];
            }

            return levelFeatures;
        }

        public void AddLevelFeatures(int level, params FeatureDefinition[] features)
        {
            GetOrMakeLevelFeatures(level).AddRange(features);
            _fullSetIsDirty = true;
        }
        
        public void AddLevelFeatures(int level, IEnumerable<FeatureDefinition> features)
        {
            GetOrMakeLevelFeatures(level).AddRange(features);
            _fullSetIsDirty = true;
        }
        
        public void SetLevelFeatures(int level, params FeatureDefinition[] features)
        {
            GetOrMakeLevelFeatures(level).SetRange(features);
            _fullSetIsDirty = true;
        }
        
        public void SetLevelFeatures(int level, IEnumerable<FeatureDefinition> features)
        {
            GetOrMakeLevelFeatures(level).SetRange(features);
            _fullSetIsDirty = true;
        }

        public List<FeatureDefinition> GetLevelFeatures(int level)
        {
            //TODO: decide if we want to wrap this into new list, to be sure htis one is immutable
            return FeaturesByLevel.GetValueOrDefault(level);
        }

    }

    public class CustomFeatureDefinitionSetBuilder : FeatureDefinitionBuilder<CustomFeatureDefinitionSet,
        CustomFeatureDefinitionSetBuilder>
    {
        public CustomFeatureDefinitionSetBuilder(string name, Guid namespaceGuid) : base(name, namespaceGuid)
        {
        }

        public CustomFeatureDefinitionSetBuilder(string name, string definitionGuid) : base(name, definitionGuid)
        {
        }

        public CustomFeatureDefinitionSetBuilder(CustomFeatureDefinitionSet original, string name, Guid namespaceGuid) : base(original, name, namespaceGuid)
        {
        }

        public CustomFeatureDefinitionSetBuilder(CustomFeatureDefinitionSet original, string name, string definitionGuid) : base(original, name, definitionGuid)
        {
        }

        public CustomFeatureDefinitionSetBuilder AddLevelFeatures(int level, params FeatureDefinition[] features)
        {
            Definition.AddLevelFeatures(level, features);
            return this;
        }

        public CustomFeatureDefinitionSetBuilder AddLevelFeatures(int level, List<FeatureDefinition> features)
        {
            Definition.AddLevelFeatures(level, features);
            return this;
        }
        
        public CustomFeatureDefinitionSetBuilder SetLevelFeatures(int level, params FeatureDefinition[] features)
        {
            Definition.SetLevelFeatures(level, features);
            return this;
        }

        public CustomFeatureDefinitionSetBuilder SetLevelFeatures(int level, List<FeatureDefinition> features)
        {
            Definition.SetLevelFeatures(level, features);
            return this;
        }

        public CustomFeatureDefinitionSetBuilder SetRequireClassLevels(bool value)
        {
            Definition.RequireClassLevels = value;
            return this;
        }
    }

    public class FeatureDefinitionRemover : FeatureDefinition, IFeatureDefinitionCustomCode
    {
        public FeatureDefinition FeatureToRemove { get; set; }

        public void ApplyFeature(RulesetCharacterHero hero, string tag)
        {
            CustomFeaturesContext.RecursiveRemoveCustomFeatures(hero, tag, new() { FeatureToRemove }, handleCustomCode: false);
        }

        public void RemoveFeature(RulesetCharacterHero hero, string tag)
        {
            ServiceRepository.GetService<ICharacterBuildingService>().GetLastAssignedClassAndLevel(hero, out var lastClass, out var classLevel);
            //technically we return feature not where we took it from
            tag = AttributeDefinitions.GetClassTag(lastClass, classLevel - 1);
            ServiceRepository.GetService<ICharacterBuildingService>()
                .GrantFeatures(hero, new List<FeatureDefinition> {FeatureToRemove}, tag, false);
        }
    }

    public class FeatureDefinitionRemoverBuilder 
        : FeatureDefinitionBuilder<FeatureDefinitionRemover, FeatureDefinitionRemoverBuilder>
    {
        #region Constructors

        public FeatureDefinitionRemoverBuilder(string name, Guid namespaceGuid) : base(name, namespaceGuid)
        {
        }

        public FeatureDefinitionRemoverBuilder(string name, string definitionGuid) : base(name, definitionGuid)
        {
        }

        public FeatureDefinitionRemoverBuilder(FeatureDefinitionRemover original, string name, Guid namespaceGuid) : base(
            original, name, namespaceGuid)
        {
        }

        public FeatureDefinitionRemoverBuilder(FeatureDefinitionRemover original, string name, string definitionGuid) :
            base(original, name, definitionGuid)
        {
        }

        #endregion

        private static string WrapName(string name) { return $"{$"{name}Remover"}"; }

        public static FeatureDefinitionRemoverBuilder CreateFrom(FeatureDefinition feature)
        {
            return Create(WrapName(feature.Name), CENamespaceGuid)
                .SetGuiPresentation(
                    feature.GuiPresentation.Title, 
                    feature.GuiPresentation.Description,
                    feature.GuiPresentation.SpriteReference
                )
                .SetFeatureToRemove(feature);
        }

        public static FeatureDefinitionRemover CreateOrGetFrom(FeatureDefinition feature)
        {
            var name = WrapName(feature.Name);
            try
            {
                var result = DatabaseHelper.GetDefinition<FeatureDefinition>(name, null);
                if (result != null && result is FeatureDefinitionRemover remover)
                {
                    return remover;
                }
            }
            catch (SolastaModApiException)
            {
            }

            return CreateFrom(feature).AddToDB();
        }

        public FeatureDefinitionRemoverBuilder SetFeatureToRemove(FeatureDefinition feature)
        {
            Definition.FeatureToRemove = feature;
            return this;
        }
    }

    public class ReplaceCustomFeatureDefinitionSet : CustomFeatureDefinitionSet
    {
        public CustomFeatureDefinitionSet ReplacedFeatureSet { get; private set; }

        public void SetReplacedFeatureSet(CustomFeatureDefinitionSet featureSet)
        {
            ReplacedFeatureSet = featureSet;
            GuiPresentation.SetSpriteReference(featureSet.GuiPresentation.SpriteReference);
            foreach (var level in featureSet.AllLevels)
            {
                var features = featureSet.GetLevelFeatures(level);
                var removers = features.Select(FeatureDefinitionRemoverBuilder.CreateOrGetFrom);
                SetLevelFeatures(level, removers);
            }
        }
    }

    public class ReplaceCustomFeatureDefinitionSetBuilder : FeatureDefinitionBuilder<ReplaceCustomFeatureDefinitionSet, ReplaceCustomFeatureDefinitionSetBuilder>
    {
        public ReplaceCustomFeatureDefinitionSetBuilder(string name, Guid namespaceGuid) : base(name, namespaceGuid)
        {
        }

        public ReplaceCustomFeatureDefinitionSetBuilder(string name, string definitionGuid) : base(name, definitionGuid)
        {
        }

        public ReplaceCustomFeatureDefinitionSetBuilder(ReplaceCustomFeatureDefinitionSet original, string name, Guid namespaceGuid) : base(original, name, namespaceGuid)
        {
        }

        public ReplaceCustomFeatureDefinitionSetBuilder(ReplaceCustomFeatureDefinitionSet original, string name, string definitionGuid) : base(original, name, definitionGuid)
        {
        }

        public ReplaceCustomFeatureDefinitionSetBuilder SetReplacedFeatureSet(CustomFeatureDefinitionSet featureSet)
        {
            Definition.SetReplacedFeatureSet(featureSet);
            return this;
        }
    }
}
