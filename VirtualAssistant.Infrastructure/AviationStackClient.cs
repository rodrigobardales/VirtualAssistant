﻿using System.Text.Json;

namespace VirtualAssistant.Infrastructure;

public class AviationStackClient : IDisposable
{
    private readonly HttpClient _client;

    public AviationStackClient()
    {
        _client = new HttpClient();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _client.Dispose();
        }
    }

    public async Task<Provider?> GetFromApiByIdAsync(Guid id)
    {
        var response = await _client.GetAsync($"https://localhost:5001/api/providers/{id}");
        var responseContent = await response.Content.ReadAsStringAsync();
        var provider = JsonSerializer.Deserialize<Provider>(responseContent);
        return provider;
    }
}

