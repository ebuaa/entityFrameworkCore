﻿using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

using System.Runtime.CompilerServices;  // Importation du namespace pour accéder à des fonctionnalités liées à la compilation (non utilisé dans ce code mais peut être nécessaire pour des attributs de compilation ou des méthodes spécifiques)

using hero_csharp.Models;

namespace hero_csharp.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? SchoolId { get; set; }
        public School? School { get; set; }
        public List<SuperPower>? SuperPowers { get; set; }
    }


}