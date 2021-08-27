using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace jsonGenerator
{
    public static class Program
    {

        static void Main(string[] args)
        {
            // Generate
            List<Node> nodes = new List<Node>(); List<Edge> edges = new List<Edge>();
            new JsonSerialize().Generate(nodes, edges); 
            new JsonSerialize().PlaceNodes(edges,nodes);

            string fileName = @"C:\Users\hafneral\source\repos\Render\data.json";
            string jsonStringNodes = JsonSerializer.Serialize(nodes);
            string jsonStringEdges = JsonSerializer.Serialize(edges);

            File.WriteAllText(fileName, "{ \"nodes\": " + jsonStringNodes + ",\"edges\":" + jsonStringEdges + "}");
        }
    }
}