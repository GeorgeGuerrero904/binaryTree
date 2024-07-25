using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Node
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string role { get; set; }
        private List<Node>? children { get; set; }

        public void addChild(Node child)
        {
            if (children == null)
            {
                children = new List<Node>();
            }
            children.Add(child);
        }
        public void removeChild(int childId)
        {
            if (children != null)
            {
                children.RemoveAll(x => x.id == childId);
            }
        }

        public List<Node> getChildren()
        {
            if (children != null)
            {
                return children;
            }
            else
            {
                return new List<Node>();
            }
        }

        public static Node initNode()
        {
            Console.WriteLine("Type node ID");
            string nodeId = Console.ReadLine() ?? "0";
            Console.WriteLine("Type node name");
            string nodeName = Console.ReadLine() ?? "";
            Console.WriteLine("Type node role");
            string nodeRole = Console.ReadLine() ?? "";

            return new Node()
            {
                id = Convert.ToInt32(nodeId),
                name = nodeName,
                role = nodeRole
            };
        }
    }
}
