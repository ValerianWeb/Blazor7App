﻿using Blazor7App.Shared;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Json;


namespace Blazor7App.Client.Services
{
    /// <summary>
    /// This class provides access to the database via the web api.
    /// Derek Peacock.  2023-09-03
    /// </summary>
    [AllowAnonymous]
    public class ProductService
    {
        // add methods to call all the standard web api methods in the
        // ProductsController in the Server Project

        private readonly HttpClient _httpClient;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [AllowAnonymous]
        public async Task GetProducts()
        {
            var data = await _httpClient.GetFromJsonAsync<List<Product>>("api/products"); 
            if(data != null) Products = data;
        }

        public async Task<Product> GetProduct(int id)
        {
			var data = await _httpClient.GetFromJsonAsync<Product>($"api/products/{id}");
			return data;
		}

        public async Task<Product> AddProduct(Product product)
        {
			var result = await _httpClient.PostAsJsonAsync<Product>("api/products", product);
			return await result.Content.ReadFromJsonAsync<Product>();
		}

        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await _httpClient.PutAsJsonAsync<Product>("api/products", product);
            return await result.Content.ReadFromJsonAsync<Product>();
        }

        public async Task DeleteProduct(int id)
        {
			await _httpClient.DeleteAsync($"api/products/{id}");
		}
    }
}
