using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GetDataBlazor.Data;

namespace GetDataBlazor.Services
{
    public class CommentService
    {
        private readonly HttpClient _httpClient;

        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Comment>> GetCommentsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Comment>>("https://jsonplaceholder.typicode.com/comments")
                       ?? new List<Comment>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching comments: {ex.Message}");
                return new List<Comment>();
            }
        }

        public async Task<Comment?> GetCommentByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Comment>($"https://jsonplaceholder.typicode.com/comments/{id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching comment with ID {id}: {ex.Message}");
                return null;
            }
        }
    }
}
