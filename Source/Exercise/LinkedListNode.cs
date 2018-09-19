namespace Exercise
{
    class LinkedListNode
    {
        public int Info { get; private set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int i)
	    {
		    Info = i;
	        Next = null;
	    }
    }
}
