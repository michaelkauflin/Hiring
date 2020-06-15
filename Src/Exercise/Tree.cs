using System;

namespace Exercise
{
    public class Tree
    {
        public Node Root { get; private set; }
	
	    public Tree(Node n)
	    {
	        Root = n;
	    }

        public int Sum()
        {
            return Sum(Root);
        }

        public int Min()
        {
            return Min(Root);
        }
	
	    private static int Sum(Node n)
	    {
		    if (n == null)
		    {
			    return 0;
		    }
		    return n.Info + Sum(n.Left) + Sum(n.Right);
	    }

        private static int Min(Node n)
        {
            int firstMin;
            if (n.Left != null)
            {
                firstMin = Math.Min(Min(n.Left), n.Info);
            }
            else
            {
                firstMin = n.Info;
            }
            if (n.Right != null)
            {
                return Math.Min(Min(n.Right), firstMin);
            }
            else
            {
                return firstMin;
            }
        }
    }
}
