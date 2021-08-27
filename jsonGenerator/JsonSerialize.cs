using System;
using System.Collections.Generic;
using System.Linq;

namespace jsonGenerator
{
    public class JsonSerialize
    {
        #region Constants
        public const int DEFAULT_NODE_SIZE = 10; // Privzeta velikost navadnih vozlisc.
        public const int MANDATORY_DISTANCE = 50; // Potrebna razdalja enega vozlisca od vseh ostalih, da se ne prekrivajo - Pri vecjih vrednostih se zacikla, ker zmanjka moznosti.
        
        public const double MULTIPLIER = 2.0f; // Multiplikator za dolocitev centralnih vozlisc (Manjsi kot je, vec vozlisc bo padlo v kategorijo centralnih).  1 center = 315 vec = 2 2 centra = 5
        public const int X_OFFSET_BETWEEN_CENTER_NODES = 150; // Razdalja X in Y med centralnimi vozlisci.
        public const int Y_OFFSET_BETWEEN_CENTER_NODES = 50;
        public const int STARTING_LENGTH = 80; // Oddaljenost malih vozlisc od centralnih.

        public const int MAXIMUM_NODES_ON_CENTER = 6; // Maksimalno stevilo vozlisc, postavljenih blizu centralnega, preden se poveca razdalja in spremeni kot postavitve.
        public const int ANGLE_OFFSET_BETWEEN_NODES = 25; // Razlika v kotu pri postavitvi vozlisc (360/MAXIMUM_NODES_ON_CENTER je najvecja vrednost, za pravilen krog).

        public const int MAXIMUM_NODES_ON_TWO_CENTERS = 8; // Maksimalno stevilo vozlisc, postavljenih blizu centralnega, ko sta centralna najvec dva.
        public const int ANGLE_OFFSET_BETWEEN_NODES_WITH_TWO_CENTERS = 22; // Razlika v kotu pri postavitvi vozlisc za primer dveh centralnih vozlisc.

        public const int MAXIMUM_NODES_ON_SINGLE_CENTER = 10; // Maksimalno stevilo vozlisc, postavljenih blizu centralnega, ko je centralen samo en.
        public const int ANGLE_OFFSET_BETWEEN_NODES_WITH_SINGLE_CENTER = 36; // Razlika v kotu pri postavitvi vozlisc za primer enega centralnega vozlisca.

        public const bool REMOVE_CONNECTIONLESS_NODES = true; // Odstani vozlisca brez povezav.
        #endregion

        #region generation

        public void Generate(List<Node> nodes, List<Edge> edges)
        {
            nodes.Add(new Node("n1", "UPO", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n2", "Paketomati.WebApi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n3", "Dostava.Api", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n4", "eOkraji.Api", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n5", "ePero.Podpisi.WebApi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n6", "ADPortal.WebApi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n7", "Posiljke.Tujina.Api", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n8", "eSprejem.WebApi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n9", "eAmazonService", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n10", "eDirectMe.WebApi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n11", "ePero", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n12", "eHpExpress", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n13", "eBencinskiServis", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n14", "LocoDels", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n15", "ePero.Pushback", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n16", "eOdkupnina", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n17", "eStevilke", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n18", "ePero3", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n19", "Test", 0, 0, DEFAULT_NODE_SIZE));
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
            nodes.Add(new Node("n20", "ePortalSql01", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n21", "eWebSpremnica", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n22", "UpoMobileService", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n23", "ePodpisi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n24", "SqlStrezniki", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n25", "eIntereuropa", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n26", "EmailDirectService", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n27", "eDovolilnica", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n28", "eSledenjePogodbeniki", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n29", "eDovolilnice", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n30", "eWebSpremnica", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n31", "DWS", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n32", "eSledenje", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n33", "eLogistika", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n34", "eSpremnica.Service", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n41", "Mobile UPO", 0, 0, DEFAULT_NODE_SIZE));


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
            nodes.Add(new Node("n35", "ePayment.WebApi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n36", "ePaymentPayByLink", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n37", "ePayment", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n38", "ePaketomati.WebApp", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n39", "eLink.WebApi", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n40", "SCALASQL", 0, 0, DEFAULT_NODE_SIZE));
            edges.Add(new Edge("e36", "n35", "n39"));
            edges.Add(new Edge("e37", "n35", "n40"));
            edges.Add(new Edge("e38", "n36", "n35"));
            edges.Add(new Edge("e39", "n37", "n35"));
            edges.Add(new Edge("e40", "n38", "n35"));
            edges.Add(new Edge("e41", "n30", "n35"));
            edges.Add(new Edge("e42", "n2", "n35"));

            edges.Add(new Edge("e43", "n41", "n30"));
            edges.Add(new Edge("e44", "n41", "n12"));
            edges.Add(new Edge("e45", "n41", "n19"));
            edges.Add(new Edge("e46", "n41", "n15"));
            edges.Add(new Edge("e47", "n41", "n7"));
            edges.Add(new Edge("e48", "n14", "n41"));
            edges.Add(new Edge("e49", "n19", "n41"));
            edges.Add(new Edge("e50", "n7", "n41"));
            edges.Add(new Edge("e51", "n33", "n41"));
            edges.Add(new Edge("e52", "n23", "n41"));
            edges.Add(new Edge("e53", "n13", "n41"));
            edges.Add(new Edge("e54", "n16", "n41"));
            edges.Add(new Edge("e55", "n41", "n2"));
            edges.Add(new Edge("e56", "n41", "n6"));
            edges.Add(new Edge("e57", "n23", "n41"));
            edges.Add(new Edge("e58", "n14", "n41"));
            edges.Add(new Edge("e59", "n28", "n41"));
            edges.Add(new Edge("e60", "n41", "n4"));
            edges.Add(new Edge("e61", "n41", "n19"));
            edges.Add(new Edge("e62", "n22", "n41"));


           
            nodes.Add(new Node("n42", "fibre", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n43", "g34g", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n44", "34g", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n45", "htrh", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n46", "rthrth", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n47", "bla", 0, 0, DEFAULT_NODE_SIZE));


            nodes.Add(new Node("n48", "bla123", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n49", "bla1234", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n50", "bla12345", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n51", "bla123456", 0, 0, DEFAULT_NODE_SIZE));
            nodes.Add(new Node("n52", "bla1234567", 0, 0, DEFAULT_NODE_SIZE));


            edges.Add(new Edge("e68", "n48", "n49"));
            edges.Add(new Edge("e69", "n49", "n50"));
            edges.Add(new Edge("e70", "n48", "n51"));
            edges.Add(new Edge("e71", "n48", "n51"));
            edges.Add(new Edge("e72", "n48", "n52"));



            edges.Add(new Edge("e63", "n42", "n43"));
            edges.Add(new Edge("e64", "n43", "n44"));
            edges.Add(new Edge("e65", "n44", "n45"));
            edges.Add(new Edge("e66", "n45", "n35"));
            edges.Add(new Edge("e67", "n45", "n47"));
            
        }

        #endregion

        #region Methods
        public void PlaceNodes(List<Edge> aEdges, List<Node> aNodes)
        {
            FillCenter(aNodes, aEdges); // Oznacimo centralna vozlisca in napolnimo povezave.
            if(REMOVE_CONNECTIONLESS_NODES) RemoveNodesWithoutConnections(aNodes); // Odstranimo vozlisca brez povezav.

            foreach (Node node in aNodes)
            {
                if (node.center) // Najprej postavi vozlisca, ki se vezejo na vsa centralna vozlisca.
                {
                    PlaceNodesInQuadrant(aEdges, aNodes, CalculateQuadrant(aNodes, node, false), node);
                }
            }
            PlaceRemainingNodes(aNodes, aEdges); // Postavi ostala vozlisca
        }
        private void FillCenter(List<Node> aNodes, List<Edge> aEdges)
        {
            int x = 0, y = 0;
            double threshold = 0.0f;
            bool placed = false;
            SetThreshold(aNodes, aEdges, MULTIPLIER, ref threshold);
            foreach (Node node in aNodes) // Nastavi centralna vozlisca za out- in in-povezave.
            {
                if (node.connectionOutCount > threshold && !node.center) // Če (ven) povezave iz vozlisca zajemajo več kot nastavljeno mejo povezav, jih označi kot centralne
                {
                    node.size = 35;
                    node.x = x;
                    node.y = y;
                    node.center = true;
                    placed = true;
                }
                if (node.connectionInCount > threshold && !node.center) // Enako za ostale povezave, vendar je velikost manjsa, za razlikovanje.
                {
                    node.size = 25;
                    node.x = x;
                    node.y = y;
                    node.center = true;
                    placed = true;
                }
                if (placed) // Dolocitev novega x in y, za naslednjo centralno vozlisce
                {
                    x += X_OFFSET_BETWEEN_CENTER_NODES + new Random().Next(3);
                    if (y == 0)
                        y = Y_OFFSET_BETWEEN_CENTER_NODES + new Random().Next(3);
                    else if (y > 0)
                        y = (y + Y_OFFSET_BETWEEN_CENTER_NODES + new Random().Next(3)) * -1;
                    else
                        y = (y - Y_OFFSET_BETWEEN_CENTER_NODES + new Random().Next(3)) * -1;
                    placed = false;
                }
            }
            if(aNodes.FirstOrDefault(centerNode => centerNode.center == true) == null) // Ce ni centra, postavi vozlisce z najvec povezavami kot center.
            {
                List<Node> sortedNodes = aNodes.OrderByDescending(x => x.connectionInCount + x.connectionOutCount).ToList(); // Vozlisca uredimo po stevilu povezav.
                sortedNodes[0].center = true;
                sortedNodes[0].size = 25;
            }
        }
        private void RemoveNodesWithoutConnections(List<Node> aNodes)
        {
            List<Node> nodesToRemove = new List<Node>();
            foreach (Node toRemove in aNodes)
            {
                if ((toRemove.connectionInCount + toRemove.connectionOutCount) == 0)
                    nodesToRemove.Add(toRemove);
            }

            foreach (Node toRemove in nodesToRemove)
            {
                aNodes.Remove(toRemove);
            }
        }
        private void SetThreshold(List<Node> aNodes, List<Edge> aEdges, double multiplier, ref double threshold)
        {
            int sum = 0;
            bool valid = false;

            foreach (Edge edge in aEdges) // Napolni povezave
            {
                foreach (Node node in aNodes)
                {
                    if (edge.target == node.id) node.connectionInCount++;
                    if (edge.source == node.id) node.connectionOutCount++;
                }
            }

            foreach (Node node in aNodes) // Sesteje vse povezave
            {
                sum += node.connectionInCount + node.connectionOutCount;
            }

            double average = sum / aNodes.Count; // Povprecje uporabi za izracun meje za dolocitev centralnih vozlisc
            threshold = average * multiplier;

            foreach (Node node in aNodes)
            {
                if ((node.connectionInCount + node.connectionOutCount) > threshold)
                    valid = true;
            }
            if (!valid)
            {
                foreach(Node node in aNodes)
                {
                    node.connectionInCount = 0;
                    node.connectionOutCount = 0;
                }
                SetThreshold(aNodes, aEdges, multiplier * 0.8, ref threshold);
            }
        }
        private void PlaceNodesInQuadrant(List<Edge> aEdges, List<Node> aNodes, int quadrant, Node aCenter)
        {
            int r = STARTING_LENGTH, angle, newAngle = 0, maximumNodesOnCenter = MAXIMUM_NODES_ON_CENTER, angleOffsetBetweenNodes = ANGLE_OFFSET_BETWEEN_NODES;

            if(quadrant == 0) // V primeru, da je center samo en, jih postavi v krog
            {
                maximumNodesOnCenter = MAXIMUM_NODES_ON_SINGLE_CENTER;
                angleOffsetBetweenNodes = ANGLE_OFFSET_BETWEEN_NODES_WITH_SINGLE_CENTER;
            } else if(quadrant == 5 || quadrant == 6) // Če sta centra dva pa levo in desno
            {
                maximumNodesOnCenter = MAXIMUM_NODES_ON_TWO_CENTERS; 
                angleOffsetBetweenNodes = ANGLE_OFFSET_BETWEEN_NODES_WITH_TWO_CENTERS; 
            }

            foreach (Node node in aNodes)
            {
                if (!node.center && !node.placed) // Za vsa nepostavljena in necentralna vozlisca
                {
                    foreach (Edge edge in aEdges)
                    {
                        if ((edge.source == aCenter.id && edge.target == node.id) || (edge.target == aCenter.id && edge.source == node.id))
                        {
                            angle = newAngle + angleOffsetBetweenNodes * (aCenter.nodesPlaced % maximumNodesOnCenter);
                            switch (quadrant)
                            {
                                case 1: //x+ y-
                                    node.x = Convert.ToInt32(aCenter.x + r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aCenter.y - r * Math.Sin(angle * Math.PI / 180.0f));
                                    aCenter.nodesPlaced++;
                                    break;
                                case 2: //x- y-
                                    node.x = Convert.ToInt32(aCenter.x - r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aCenter.y - r * Math.Sin(angle * Math.PI / 180.0f));
                                    aCenter.nodesPlaced++;
                                    break;
                                case 3: //x- y+
                                    node.x = Convert.ToInt32(aCenter.x - r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aCenter.y + r * Math.Sin(angle * Math.PI / 180.0f));
                                    aCenter.nodesPlaced++;
                                    break;
                                case 4: //x+ y+
                                    node.x = Convert.ToInt32(aCenter.x + r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aCenter.y + r * Math.Sin(angle * Math.PI / 180.0f));
                                    aCenter.nodesPlaced++;
                                    break;
                                case 0: // Začni v 4. kvadrantu in idi v krog
                                    node.x = Convert.ToInt32(aCenter.x + r * Math.Cos(angle * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aCenter.y + r * Math.Sin(angle * Math.PI / 180.0f));
                                    aCenter.nodesPlaced++;
                                    break;
                                case 5: // Začni v 3. kvadrantu in naredi polkrog (90° offset)
                                    node.x = Convert.ToInt32(aCenter.x - r * Math.Cos((angle - 90) * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aCenter.y + r * Math.Sin((angle - 90) * Math.PI / 180.0f));
                                    aCenter.nodesPlaced++;
                                    break;
                                case 6: // Začni v 3. kvadrantu in naredi polkrog (90° offset)
                                    node.x = Convert.ToInt32(aCenter.x - r * Math.Cos((angle + 90) * Math.PI / 180.0f));
                                    node.y = Convert.ToInt32(aCenter.y + r * Math.Sin((angle + 90) * Math.PI / 180.0f));
                                    aCenter.nodesPlaced++;
                                    break;
                            }
                            node.placed = true;
                            if (aCenter.nodesPlaced % maximumNodesOnCenter == 0) // Ko dosezemo maksimalno stevilo vozlisc v eni vrsti, gremo na naslednjo (poveca se razdalja, spremeni se kot)
                            {
                                r += STARTING_LENGTH;
                                newAngle = aCenter.nodesPlaced;
                            }
                        }
                    }
                }
            }
        }
        private int CalculateQuadrant(List<Node> aNodes, Node aNode, bool remaining)
        {
            if (aNode.center && !remaining)
            {
                int centers = 0; // Preveri stevilo centralnih vozlisc
                foreach (Node node in aNodes)
                {
                    if (node.center)
                        centers++;
                }

                if (centers == 1) // Če je eno, postavi ostale v krog
                    return 0;
                else if (centers == 2) // Če sta dva, postavi ene na levo stran, ene na desno
                {
                    foreach (Node node in aNodes)
                    {
                        if (node.center)
                            if (node.id == aNode.id)
                                return 5; // Leva stran za prvo centralno
                            else
                                return 6; // Desna stran za drugo centralno
                    }
                }
            }

            int xCoord = 0, yCoord = 0;
            foreach (Node node in aNodes)
            {
                if (node.id != aNode.id) // Preracunaj povprecno pozicijo ostalih centralnih vozlisc
                {
                    xCoord += aNodes.First(xNode => xNode.id == node.id).x;
                    yCoord += aNodes.First(yNode => yNode.id == node.id).y;
                }
            }

            if (aNodes.Count != 0)
            {
                xCoord /= aNodes.Count;
                yCoord /= aNodes.Count;
            }

            // Vrni stevilo kvadranta, v katerega vnasamo ostala vozlisca

            if (xCoord > aNode.x && yCoord > aNode.y)
                return 2;
            else if (xCoord > aNode.x && yCoord < aNode.y)
                return 3;
            else if (xCoord < aNode.x && yCoord < aNode.y)
                return 4;
            else return 1;
        }
        private void PlaceRemainingNodes(List<Node> aNodes, List<Edge> aEdges)
        {
            List<Node> nodesToPlace = aNodes.FindAll(x => x.center == false && x.placed == false).ToList();
            
            foreach(Node toPlace in nodesToPlace)
            {
                foreach (Edge edge in aEdges)
                {
                    if (edge.target == toPlace.id) // Poiscemo povezavo, ki vodi v nepostavljeno vozlisce
                    {
                        foreach (Node placeFrom in aNodes) // Poiscemo vozlisce, ki je vir te povezave
                        {
                            if (placeFrom.id == edge.source && placeFrom.placed)
                            {
                                PlaceNode(placeFrom, toPlace, aNodes, ANGLE_OFFSET_BETWEEN_NODES * 2, 1.0f);
                                PlaceRemainingNodes(aNodes, aEdges); // Rekurzivno klicemo funkcijo, dokler se ne postavijo vsa vozlisca
                            }
                        }
                    }

                    if (edge.source == toPlace.id) // Poiscemo povezavo, ki izvira v tem vozliscu
                    {
                        foreach (Node placeFrom in aNodes) // Poiscemo vozlisce, ki je tarca nase povezave
                        {
                            if (placeFrom.id == edge.target && placeFrom.placed)
                            {
                                PlaceNode(placeFrom, toPlace, aNodes, ANGLE_OFFSET_BETWEEN_NODES * 2, 1.0f);
                                PlaceRemainingNodes(aNodes, aEdges);
                            }
                        }
                    }
                }
            }

            Node Center = new Node();
            Center.nodesPlaced = int.MaxValue;

            foreach (Node center in aNodes) // Najdi centralno vozlisce z najmanj povezanimi vozlisci
            {
                if (center.center && Center.nodesPlaced > center.nodesPlaced)
                    Center = center;
            }

            foreach (Node toPlace in aNodes)
            {
                if (!toPlace.placed && !toPlace.center)
                {
                    PlaceNode(Center, toPlace, aNodes, ANGLE_OFFSET_BETWEEN_NODES, 1.1f);
                    PlaceRemainingNodes(aNodes, aEdges);
                }
            }
        }
        private void PlaceNode(Node aNode, Node aToPlaceNode, List<Node> aNodes, int aAngle, double aDistanceMultiplier)
        {
            int quadrant = CalculateQuadrant(aNodes, aNode, true);
            switch (quadrant)
            {
                case 1:
                    aToPlaceNode.x = Convert.ToInt32(aNode.x + aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Cos(aAngle * Math.PI / 180.0f));
                    aToPlaceNode.y = Convert.ToInt32(aNode.y - aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Sin(aAngle * Math.PI / 180.0f));
                    break;
                case 2:
                    aToPlaceNode.x = Convert.ToInt32(aNode.x - aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Cos(aAngle * Math.PI / 180.0f));
                    aToPlaceNode.y = Convert.ToInt32(aNode.y - aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Sin(aAngle * Math.PI / 180.0f));
                    break;
                case 3:
                    aToPlaceNode.x = Convert.ToInt32(aNode.x - aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Cos(aAngle * Math.PI / 180.0f));
                    aToPlaceNode.y = Convert.ToInt32(aNode.y + aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Sin(aAngle * Math.PI / 180.0f));
                    break;
                case 4:
                    aToPlaceNode.x = Convert.ToInt32(aNode.x + aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Cos(aAngle * Math.PI / 180.0f));
                    aToPlaceNode.y = Convert.ToInt32(aNode.y + aDistanceMultiplier * STARTING_LENGTH / 2 * Math.Sin(aAngle * Math.PI / 180.0f));
                    break;
            }
            if (CheckDistanceOfNodes(aToPlaceNode, aNodes))
            {
                aNode.nodesPlaced++;
                aToPlaceNode.placed = true;
            }
            else
                PlaceNode(aNode, aToPlaceNode, aNodes, aAngle * 2, aDistanceMultiplier*1.05);
        }
        private bool CheckDistanceOfNodes(Node toPlace, List<Node> aNodes) // Pregleda ali so vsa vozlisca dovolj oddljena, ce niso vrne false
        {
            foreach (Node n in aNodes)
            {
                if (Math.Abs(n.x - toPlace.x) <= MANDATORY_DISTANCE && Math.Abs(n.y - toPlace.y) <= MANDATORY_DISTANCE && n.id != toPlace.id)
                    return false;
            }
            return true;
        }
        #endregion

    }
}
