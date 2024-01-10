using Base_de_Dados_Spotify;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System;
using CsvHelper.Configuration;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int troca = 0, comp = 0;
        var stopwatch = new Stopwatch();
        string filePath = "C:\\Users\\mbent\\Downloads\\spotify-2023.csv";

        List<Dataset> dados = new List<Dataset>();

        using (var reader = new StreamReader(filePath))
        {
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };

            using (var csv = new CsvReader(reader, csvConfig))
            {                
                csv.Context.RegisterClassMap<DatasetMap>();                
                dados = csv.GetRecords<Dataset>().ToList();
            }
        }

        //foreach (var item in dados) //Lista desordenada
        //{
        //    Console.WriteLine($"TrackName: {item.TrackName}");
        //}

        /*
         * para trocar a ordenacao do nome da musica para nome do artista é so trocar os "TrackName" nos metodos
         */

        stopwatch.Start();
        //ESCOLHA O METODO DE ORDENACAO

        troca = 0;//tem que zerar a troca e a comp fora do quick pq ele é recusivo
        comp = 0;
        //Ordenacao.quickSort(dados, 0, dados.Count - 1, ref comp, ref troca);
        //Ordenacao.shellSort(dados, ref comp, ref troca); 
        //Ordenacao.Bolha(dados, ref comp, ref troca);
        //Ordenacao.insercao(dados, ref comp, ref troca);
        //Ordenacao.selecao(dados, ref comp, ref troca);


        stopwatch.Stop(); 
        long elapsed_time = stopwatch.ElapsedMilliseconds;


        foreach (var item in dados) //Lista ordenada
        {
            Console.WriteLine($"TrackName: {item.TrackName}");
        }
        Console.WriteLine($"Troca: {troca} \n Comparações: {comp}");
        Console.WriteLine("Tempo de execução: " + String.Format("{0:F4}seg", elapsed_time / 1000.0));

        Console.ReadKey();
    }
}