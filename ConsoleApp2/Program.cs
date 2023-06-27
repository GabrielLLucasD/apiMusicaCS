using (HttpClient cliente = new HttpClient()) {
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.Write(resposta);
    }

    catch(Exception ex) {
        Console.WriteLine($"Ocorreu o seguinte erro:{ex.Message}");
    }

}

