namespace Terminals.Configuration.Files.Main.Groups
{
    using System;
    using System.Configuration;
    using Favorites;

    [Serializable]
    public class GroupConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string) this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("favoriteAliases")]
        [ConfigurationCollection(typeof (FavoriteAliasConfigurationElementCollection))]
        public FavoriteAliasConfigurationElementCollection FavoriteAliases
        {
            get { return (FavoriteAliasConfigurationElementCollection) this["favoriteAliases"]; }
            set { this["favoriteAliases"] = value; }
        }
    }
}