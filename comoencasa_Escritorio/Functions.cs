using comoencasa_Escritorio.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace comoencasa_Escritorio
{
    public static class Functions
    {

        public static async Task<User> LoginAsync(string email, string password)
        {
            var userData = new
            {
                email,
                password
            };

            return await APIConnection.PostAsync<User>("users/login", userData);
        }

        public static async Task<List<Recipe>> GetAllRecipes()
        {
            return await APIConnection.GetAsync<List<Recipe>>("recipes/allRecipes");
        }

        public static async Task<Recipe> GetRecipeById(long id)
        {
            return await APIConnection.GetAsync<Recipe>($"recipes/{id}");
            
        }

        public static async Task<Recipe> CreateRecipe(Recipe dto)
        {
            return await APIConnection.PostAsync<Recipe>($"recipes/newRecipe", dto);
        }

        public static async Task<Recipe> UpdateRecipe(Recipe dto)
        {
            return await APIConnection.PutAsync<Recipe>($"recipes/update", dto);
        }

        public static async Task DeleteRecipe(long id)
        {
            await APIConnection.DeleteAsync($"recipes/delete/{id}");
        }


        public static async Task<List<Ingredient>> GetAllIngredients()
        {
            return await APIConnection.GetAsync<List<Ingredient>>("ingredients/all");
        }

        public static async Task<Ingredient> GetIngredientById(long id)
        {
            return await APIConnection.GetAsync<Ingredient>($"ingredients/{id}");
        }

        public static async Task<Ingredient> CreateIngredient(Ingredient dto)
        {
            return await APIConnection.PostAsync<Ingredient>($"ingredients/new", dto);
        }

        public static async Task<Ingredient> UpdateIngredient(Ingredient dto)
        {
            return await APIConnection.PutAsync<Ingredient>($"ingredients/update", dto);
        }

        public static async Task DeleteIngredient(long id)
        {
            await APIConnection.DeleteAsync($"ingredients/delete/{id}");
        }

        public static async Task<List<User>> GetAllUsers()
        {
            return await APIConnection.GetAsync<List<User>>("users/all");
        }

        public static async Task DeleteUser(long id)
        {
            await APIConnection.DeleteAsync($"users/delete/{id}");
        }



    }
}
