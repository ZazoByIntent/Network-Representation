using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace jsonGenerator
{
    class Program
    {
        #region Constants
        public const int DEFAULT_SIZE = 10;
        public const int SOCIAL_DISTANCING = 20;
        #endregion

        #region Methods
        public static void Generate(List<Node> nodes, List<Edge> edges)
        {
            nodes.Add(new Node("n1", "UPO", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n2", "Paketomati.WebApi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n3", "Dostava.Api", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n4", "eOkraji.Api", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n5", "ePero.Podpisi.WebApi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n6", "ADPortal.WebApi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n7", "Posiljke.Tujina.Api", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n8", "eSprejem.WebApi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n9", "eAmazonService", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n10", "eDirectMe.WebApi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n11", "ePero", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n12", "eHpExpress", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n13", "eBencinskiServis", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n14", "LocoDels", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n15", "ePero.Pushback", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n16", "eOdkupnina", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n17", "eStevilke", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n18", "ePero3", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n19", "Test", 0, 0, DEFAULT_SIZE));
            edges.Add(new Edge("e1", "n1", "n2"));
            edges.Add(new Edge("e2", "n1", "n3"));
            edges.Add(new Edge("e3", "n1", "n4"));
            edges.Add(new Edge("e4", "n1", "n5"));
            edges.Add(new Edge("e5", "n1", "n6"));
            edges.Add(new Edge("e6", "n1", "n7"));
            edges.Add(new Edge("e7", "n1", "n8"));
            edges.Add(new Edge("e8", "n1", "n9"));
            edges.Add(new Edge("e9", "n1", "n10"));
            edges.Add(new Edge("e10", "n1", "n11"));
            edges.Add(new Edge("e11", "n1", "n12"));
            edges.Add(new Edge("e12", "n1", "n13"));
            edges.Add(new Edge("e13", "n1", "n14"));
            edges.Add(new Edge("e14", "n1", "n15"));
            edges.Add(new Edge("e15", "n1", "n16"));
            edges.Add(new Edge("e16", "n1", "n17"));
            edges.Add(new Edge("e17", "n1", "n18"));
            edges.Add(new Edge("e18", "n1", "n19"));
            nodes.Add(new Node("n20", "ePortalSql01", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n21", "eWebSpremnica", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n22", "UpoMobileService", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n23", "ePodpisi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n24", "SqlStrezniki", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n25", "eIntereuropa", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n26", "EmailDirectService", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n27", "eDovolilnica", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n28", "eSledenjePogodbeniki", 0, 0, DEFAULT_SIZE)); 
            nodes.Add(new Node("n29", "eDovolilnice", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n30", "eWebSpremnica", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n31", "DWS", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n32", "eSledenje", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n33", "eLogistika", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n34", "eSpremnica.Service", 0, 0, DEFAULT_SIZE));
            edges.Add(new Edge("e19", "n21", "n20"));
            edges.Add(new Edge("e20", "n22", "n20"));
            edges.Add(new Edge("e21", "n23", "n20"));
            edges.Add(new Edge("e22", "n24", "n20"));
            edges.Add(new Edge("e23", "n25", "n20"));
            edges.Add(new Edge("e24", "n26", "n20"));
            edges.Add(new Edge("e25", "n27", "n20"));
            edges.Add(new Edge("e26", "n28", "n20"));
            edges.Add(new Edge("e27", "n11", "n20"));
            edges.Add(new Edge("e28", "n29", "n20"));
            edges.Add(new Edge("e29", "n30", "n20"));
            edges.Add(new Edge("e30", "n31", "n20"));
            edges.Add(new Edge("e31", "n32", "n20"));
            edges.Add(new Edge("e32", "n33", "n20"));
            edges.Add(new Edge("e33", "n34", "n20"));
            edges.Add(new Edge("e34", "n15", "n20"));
            edges.Add(new Edge("e35", "n18", "n20"));
            nodes.Add(new Node("n35", "ePayment.WebApi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n36", "ePaymentPayByLink", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n37", "ePayment", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n38", "ePaketomati.WebApp", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n39", "eLink.WebApi", 0, 0, DEFAULT_SIZE));
            nodes.Add(new Node("n40", "SCALASQL", 0, 0, DEFAULT_SIZE));
            edges.Add(new Edge("e36", "n35", "n39"));
            edges.Add(new Edge("e37", "n35", "n40"));
            edges.Add(new Edge("e38", "n36", "n35"));
            edges.Add(new Edge("e39", "n37", "n35"));
            edges.Add(new Edge("e40", "n38", "n35"));
            edges.Add(new Edge("e41", "n30", "n35"));
            edges.Add(new Edge("e42", "n2", "n35"));
        }
        public static void FillConnections(List<Node> aNodes, List<Edge> aEdges)
        {
            foreach(Edge e in aEdges)
            {
                foreach(Node node in aNodes)
                {
                    if (e.target == node.id) node.connectionInCount++;
                    if (e.source == node.id) node.connectionOutCount++;
                }
            }
        }
        public static void FillCenter(List<Node> aNodes, List<Edge> aEdges) 
        {
            int x = 0, y = 0, i = 1;
            int allConnections = 0;

            foreach (Node node in aNodes) // Izracunaj stevilo vseh povezav med vozlisci
            {
                allConnections += node.connectionInCount + node.connectionOutCount;
            }

            foreach (Node node in aNodes) // Nastavi centralna vozlisca za out- in in-povezave.
            {
                if (node.connectionOutCount > allConnections * 0.1) // Če povezave iz vozlisca zajemajo vec angle 10% vseh povezav, ga postavi angle centralno vozlisce
                {
                    node.size = 35;
                    node.x = x;
                    node.y = y;
                    x += 100; // Pomakni nadaljnja centralna vozlisca desno
                    y = new Random().Next(60) - 30;
                    node.center = true;
                }
                if (node.connectionInCount > allConnections * 0.1)
                {
                    node.size = 25; // Velikost je manjsa, za razlikovanje
                    node.x = x;
                    node.y = y;
                    x += 100;
                    y = new Random().Next(60) - 30;
                    node.center = true;
                }
            }
        }
        public static void PlaceNodes(List<Edge> aEdges, List<Node> aNodes)
        {
            foreach (Node node in aNodes)
            {
                if (node.center) // Najprej postavi vozlisca, ki se vezejo na vsa centralna vozlisca
                {
                    PlaceCalledNodesInQuadrant(aEdges, aNodes, CalculateQuadrant(aNodes, node), node);
                }
            }
            foreach(Node node in aNodes)
            {
                if(node.center) // Ostanejo vozlisca ki niso klicana iz centra oziroma ne klicejo v center
                {
                    PlaceCallingNodesInQuadrant(aEdges, aNodes, CalculateQuadrant(aNodes, node), node);
                }
            }
            PlaceRemainingNodes(aNodes); // Postavi ostala vozlisca
        }
        public static void PlaceCallingNodesInQuadrant(List<Edge> aEdges, List<Node> aNodes, int quadrant, Node aNode)
        {
            int r = 50; // Zacetna razdalja od izbranega centralnega vozlisca
            int angle = 0;

            foreach (Node node in aNodes)
            {
                if (!node.center && !node.placed) // Za vsa necentralna in nepostavljena vozlisca preveri, ce se vezejo na izbrano centralno.
                {
                    foreach(Edge edge in aEdges)
                    {
                        if (edge.source == node.id && edge.target == aNode.id)
                        {
                            switch (quadrant)
                            {
                                case 1: //x+ y-
                                    node.x = Convert.ToInt32(aNode.x + r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aNode.y - r * Math.Sin(angle * Math.PI / 180.0f));
                                    angle += 18;
                                    aNode.nodesPlaced++;
                                    break;
                                case 2: //x- y-
                                    node.x = Convert.ToInt32(aNode.x - r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aNode.y - r * Math.Sin(angle * Math.PI / 180.0f));
                                    angle += 18;
                                    aNode.nodesPlaced++;
                                    break;
                                case 3: //x- y+
                                    node.x = Convert.ToInt32(aNode.x - r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aNode.y + r * Math.Sin(angle * Math.PI / 180.0f));
                                    angle += 18;
                                    aNode.nodesPlaced++;
                                    break;
                                case 4: //x+ y+
                                    node.x = Convert.ToInt32(aNode.x + r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aNode.y + r * Math.Sin(angle * Math.PI / 180.0f));
                                    angle += 18;
                                    aNode.nodesPlaced++;
                                    break;
                            }

                            node.placed = true;

                            if (aNode.nodesPlaced % 5 == 0)
                            {
                                r += 50;
                                angle = aNode.nodesPlaced;
                            }
                        }
                    }
                }
            }
        }
        public static void PlaceCalledNodesInQuadrant(List<Edge> aEdges, List<Node> aNodes, int quadrant, Node aNode)
        {
            int r = 50; // Zacetna razdalja od izbranega centralnega vozlisca
            int angle = 0;

            foreach (Node node in aNodes)
            {
                if (!node.center && !node.placed && GetEdgeByTargetId(node.id, aEdges).source == aNode.id) // Za vsa necentralna in nepostavljena vozlisca preveri, ce se vezejo na izbrano centralno.
                {
                    // Ce se, jih postavi v pravilni kvadrant.
                    switch (quadrant)
                    {
                        case 1: //x+ y-
                            node.x = Convert.ToInt32(aNode.x + r * Math.Cos(angle * Math.PI / 180.0f));
                            node.y = Convert.ToInt32(aNode.y - r * Math.Sin(angle * Math.PI / 180.0f));
                            angle += 18;
                            aNode.nodesPlaced++;
                            break;
                        case 2: //x- y-
                            node.x = Convert.ToInt32(aNode.x - r * Math.Cos(angle * Math.PI / 180.0f));
                            node.y = Convert.ToInt32(aNode.y - r * Math.Sin(angle * Math.PI / 180.0f));
                            angle += 18;
                            aNode.nodesPlaced++;
                            break;
                        case 3: //x- y+
                            node.x = Convert.ToInt32(aNode.x - r * Math.Cos(angle * Math.PI / 180.0f));
                            node.y = Convert.ToInt32(aNode.y + r * Math.Sin(angle * Math.PI / 180.0f));
                            angle += 18;
                            aNode.nodesPlaced++;
                            break;
                        case 4: //x+ y+
                            node.x = Convert.ToInt32(aNode.x + r * Math.Cos(angle * Math.PI / 180.0f));
                            node.y = Convert.ToInt32(aNode.y + r * Math.Sin(angle * Math.PI / 180.0f));
                            angle += 18;
                            aNode.nodesPlaced++;
                            break;
                    }

                    node.placed = true;

                    if (aNode.nodesPlaced % 5 == 0)
                    {
                        r += 50;
                        angle = aNode.nodesPlaced;
                    }
                }
            }
        }
        public static Edge GetEdgeByTargetId(string id, List<Edge> aEdges)  // Vrne povezavo, glede na id tarce povezave
        {
            foreach (Edge e in aEdges)
            {
                if (e.target == id)
                    return e;
            }
            return new Edge();
        }
        public static int GetCoordinateById(char coordinate, string id, List<Node> aNodes) // Vrne koordinate vozlisca, glede na njegov id
        {
            foreach(Node n in aNodes)
            {
                if (n.id == id && coordinate == 'x')
                    return n.x;
                else if (n.id == id && coordinate == 'y')
                    return n.y;
            }
            return 0;
        }
        public static int CalculateQuadrant(List<Node> aNodes, Node aNode)
        {
            int xCoord = 0, yCoord = 0, i = 0;
            foreach(Node node in aNodes)
            {
                if(node.center && node.id != aNode.id) // Preracunaj povprecno pozicijo ostalih centralnih vozlisc
                {
                    i++;
                    xCoord += GetCoordinateById('x', node.id, aNodes);
                    yCoord += GetCoordinateById('y', node.id, aNodes);
                }
            }

            if (i != 0) { // Ce imamo druga centralna vozlisca, izracunaj povprecje
                xCoord /= i; 
                yCoord /= i;
            } 

            // Vrni stevilo kvadranta, v kateregea vnasamo ostala vozlisca

            if (xCoord >= aNode.x && yCoord >= aNode.y)
                return 2;
            else if (xCoord >= aNode.x && yCoord <= aNode.y)
                return 3;
            else if (xCoord <= aNode.x && yCoord <= aNode.y)
                return 4;
            else return 1;
        }
        public static void PlaceRemainingNodes(List<Node> aNodes)
        {
            int x = 0; int y = 0; int i = 0;

            foreach(Node node in aNodes) // Postavi sredino grafa
            {
                if(node.center)
                {
                    x += node.x;
                    y += node.y;
                    i++;
                }
                if (i != 0 )
                {
                    x /= i;
                    y /= i;
                }
            }

            foreach (Node node in aNodes)
            {
                if (!node.placed && !node.center)
                {
                    PlaceRandomNode(node, aNodes, new Node(string.Empty, string.Empty, x, y - 200, 0));
                }
            }
        }
        public static void PlaceRandomNode(Node toPlace, List<Node> aNodes, Node aCenter) // Rekurzivno nastavimo pravilni polozaj vozlisca
        {
            toPlace.x = aCenter.x + new Random().Next(200); // Tako dolgo poskusamo, dokler ni najdena dobra pozicija za vozlisce.
            toPlace.y = aCenter.y + new Random().Next(200);
            if(!CheckDistanceOfNodes(toPlace, aNodes))
                PlaceRandomNode(toPlace, aNodes, aCenter);
        }
        public static bool CheckDistanceOfNodes(Node toPlace, List<Node> aNodes) // Pregleda ali so vsa vozlisca dovolj oddljena, ce niso vrne false
        {
            foreach(Node n in aNodes)
            {
                if (n.id == toPlace.id)
                    continue;
                if (Math.Abs(n.x - toPlace.x) <= SOCIAL_DISTANCING && Math.Abs(n.y - toPlace.y) <= SOCIAL_DISTANCING)
                    return false;
            }
            return true;
        }
        #endregion

        static void Main(string[] args)
        {
            List<Node> nodes = new List<Node>(); List<Edge> edges = new List<Edge>(); List<Connections> connections = new List<Connections>();
            Generate(nodes, edges); FillConnections(nodes, edges); FillCenter(nodes, edges); PlaceNodes(edges,nodes);

            string fileName = @"C:\Users\hafneral\source\repos\Render\data.json";
            string jsonStringNodes = JsonSerializer.Serialize(nodes);
            string jsonStringEdges = JsonSerializer.Serialize(edges);

            File.WriteAllText(fileName, "{ \"nodes\": " + jsonStringNodes + ",\"edges\":" + jsonStringEdges + "}");
        }
    }
}
