using System;

namespace Recipes
{
    public class RecipeStep
    {
        public int Id {get;set;}
        public int RecipeId {get;set;}
        public int Number {get;set;}
        public string Text {get;set;}
    }
}