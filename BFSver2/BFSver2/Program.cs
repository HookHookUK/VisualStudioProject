using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSver2
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region DFS
            //Vertex vertexA = new Vertex("A");
            //Vertex vertexB = new Vertex("B");
            //Vertex vertexC = new Vertex("C");
            //Vertex vertexD = new Vertex("D");
            //Vertex vertexE = new Vertex("E");
            //Vertex vertexF = new Vertex("F");
            //Vertex vertexG = new Vertex("G");

            //vertexA.linkedList.Add(vertexF);
            //vertexA.linkedList.Add(vertexB);

            //vertexB.linkedList.Add(vertexA);
            //vertexB.linkedList.Add(vertexC);

            //vertexC.linkedList.Add(vertexE);
            //vertexC.linkedList.Add(vertexD);
            //vertexC.linkedList.Add(vertexB);
            //vertexC.linkedList.Add(vertexF);

            //vertexD.linkedList.Add(vertexC);
            //vertexD.linkedList.Add(vertexE);

            //vertexE.linkedList.Add(vertexC);
            //vertexE.linkedList.Add(vertexD);

            //vertexF.linkedList.Add(vertexC);
            //vertexF.linkedList.Add(vertexA);
            
            //vertexA.linkedList.Print();
            //vertexB.linkedList.Print();
            //vertexC.linkedList.Print();
            //vertexD.linkedList.Print();
            //vertexE.linkedList.Print();
            //vertexF.linkedList.Print();
            #endregion


            #region BFS
            Vertex Avertex = new Vertex("A");
            Vertex Bvertex = new Vertex("B");
            Vertex Cvertex = new Vertex("C");
            Vertex Dvertex = new Vertex("D");
            Vertex Evertex = new Vertex("E");
            Vertex Fvertex = new Vertex("F");
            Vertex Gvertex = new Vertex("G");

            Avertex.linkedList.Add(Bvertex);
            Avertex.linkedList.Add(Fvertex);

            Bvertex.linkedList.Add(Avertex);
            Bvertex.linkedList.Add(Cvertex);

            Cvertex.linkedList.Add(Bvertex);
            Cvertex.linkedList.Add(Dvertex);
            Cvertex.linkedList.Add(Evertex);
            Cvertex.linkedList.Add(Fvertex);

            Dvertex.linkedList.Add(Cvertex);
            Dvertex.linkedList.Add(Evertex);

            Evertex.linkedList.Add(Cvertex);
            Evertex.linkedList.Add(Dvertex);
            Evertex.linkedList.Add(Gvertex);

            Fvertex.linkedList.Add(Avertex);
            Fvertex.linkedList.Add(Cvertex);

            Gvertex.linkedList.Add(Evertex);

            Avertex.linkedList.Print();
            Bvertex.linkedList.Print();
            Cvertex.linkedList.Print();
            Dvertex.linkedList.Print();
            Evertex.linkedList.Print();
            Fvertex.linkedList.Print();
            Gvertex.linkedList.Print();


            #endregion



            
            


        }
    }
}
