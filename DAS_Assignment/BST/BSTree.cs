using System;

namespace BST
{
    public class BSTree
    {
        // Prvni prvek v posloupnosti bude PARENT NODE {levy a pravek potomek bude null}
        // Pokud je cislo menci jak aktualni node, tak jde cislo do prava, jinak do leva
        // Pokud se cisla rovnaji, tak jdu do prava a pak furt do leva

        //Metoda Hledej(key) -> vypise pocet duplicit
        //Odstran(key) -> odstrani klic
        //Metoda Add (key)
        //Metoda Vypis <- INORDER jde furt doleva, az tam nic neni tak vypise, jde o jedno zpet, zkusi jit do
        //prava tam nic neni jde vyse a tak dale

        public Node Root { get; set; }

        /// <summary>
        /// keys contains array of values
        /// </summary>
        /// <param name="keys"></param>
        public BSTree(int[] keys)
        {
            CreateTree(keys);
        }
        private void CreateTree(int[] keys)
        {
            if (keys.Length == 0) return;

            Root = new Node(null, keys[0]);

            for (int i = 1; i < keys.Length; i++)
            {
                Root.Add(keys[i]);
            }
        }
      
        //public Node FindNodeWithValue(int value)
        //{
        //    if (NumberOfOccurence(value) == 0) return null;



        //}
        public void Add(int value)
        {
            Root.Add(value);
        }
        public int NumberOfOccurence(int searchedValue)
        {
            int count = 0;

            Root.NumberOfOccurence(ref count, searchedValue, Root);

            return count;
        }
        /// <summary>
        /// Is most left node in tree
        /// </summary>
        /// <param name="Tree"></param>
        /// <returns></returns>
        public Node GetMinNode(Node Tree)
        {
            if (Tree == null) return null;
            else if (Tree.LeftNode == null) return Tree;
            else return GetMinNode(Tree.LeftNode);
        }

        public void Delete(Node node, int deletedValue)
        {
            Node minNode;
            if (node == null) { return; }

            else if (deletedValue < node.Value) Delete(node.LeftNode, deletedValue);  //look in the left
            else if (deletedValue > node.Value) Delete(node.RightNode, deletedValue); //look in the right
            else
            { //found node to delete

                if (node.LeftNode != null && node.RightNode != null) //two children
                {
                    minNode = GetMinNode(node.RightNode);
                    node.Value = minNode.Value;
                    Delete(node.RightNode, node.Value);
                }

                else
                { //one or zero child
                    if (node.LeftNode == null)
                    {
                        if (node.ParentNode == null) Root = node.RightNode; //The root node is to be deleted.
                        else
                        {
                            if (node.RightNode != null)
                            {
                                node.RightNode.ParentNode = node.ParentNode;
                            }

                            if (node == node.ParentNode.LeftNode)
                                node.ParentNode.LeftNode = node.RightNode;
                            else node.ParentNode.RightNode = node.RightNode;
                        }

                    }
                    else if (node.RightNode == null)
                    {
                        if (node.ParentNode == null) Root = node.LeftNode;
                        else
                        {
                            node.LeftNode.ParentNode = node.ParentNode;
                            if (node == node.ParentNode.LeftNode)
                                node.ParentNode.LeftNode= node.LeftNode;
                            else node.ParentNode.RightNode = node.LeftNode;
                        }
                    }
                }
            }
        }
    }
}
