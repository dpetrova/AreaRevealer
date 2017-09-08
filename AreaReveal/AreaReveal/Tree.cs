using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaReveal
{
    /// <summary>Represents a tree data structure</summary>    
    public class Tree
    {
        // The root of the tree
        private Node root;

        // Descendens of the root
        private List<Node> descendants;


        /// <summary>Constructs the tree</summary>
        /// <param name="root">the position of the root node</param>
        public Tree(Vector2 root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("Cannot insert null root!");
            }

            this.root = new Node(root);
        }

        /// <summary>Constructs the tree</summary>
        /// <param name="root">the position of the root node</param>
        /// <param name="children">the children of the root node</param>
        public Tree(Vector2 root, params Tree[] children)
            : this(root)
        {
            foreach (Tree child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>The root node or null if the tree is empty</summary>
        public Node Root
        {
            get { return this.root; }
        }

        /// <summary>Whether a node lies on a given edge</summary>
        /// <param name="node">node to be examined if lied on an edge</param>
        /// <param name="edgeStart">start of the edge</param>
        /// <param name="edgeEnd">end of the edge</param>
        public bool IsOnEdge( Node node, Node edgeStart, Node edgeEnd )
        {
	        if ( node.Position.X > edgeStart.Position.X && node.Position.X < edgeEnd.Position.X ) return node.Position.Y == edgeStart.Position.Y && node.Position.Y == edgeEnd.Position.Y;
	        if ( node.Position.Y > edgeStart.Position.Y && node.Position.Y < edgeEnd.Position.Y ) return node.Position.X == edgeStart.Position.X && node.Position.X == edgeEnd.Position.X;
            return false;
        }

        public Dictionary<Node, Node> FindChildren( Node parent ){

            Dictionary<Node, Node> temp =  new Dictionary<Node,Node>(); 
            
	        foreach( Node testPoint in descendants )
            {
		        foreach( Node child in testPoint ){
			        if ( IsOnEdge( parent, testPoint, child ) ) temp.Add(testPoint, child);			
		        }
	        }

            return temp;
        }

        
    }
}
