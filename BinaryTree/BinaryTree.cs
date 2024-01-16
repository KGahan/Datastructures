namespace BinaryTree
{
    public class BinaryTree
    {
        public Node root;

        public override string ToString()
        {
            return getElementsAsString(root);
        }
        string getElementsAsString(Node element)
        {
            String result = "";
            if (element == null)
                return "";
            result += getElementsAsString(element.left);
            result += getElementsAsString(element.right);
            result += element.data.ToString();
            return result;
        }

        public void InsertElement(int data)
        {
            Node currentElement = root;

            if (root == null)
            {
                root = new Node(data);
            }                
            else
            {
                while (true)
                {
                    if(currentElement != null && currentElement.data == data)
                    {
                        throw new InvalidOperationException();
                    }
                    else
                    {
                        if (data < currentElement.data)
                        {
                            if(currentElement.left == null)
                            {
                                currentElement.left = new Node(data);
                                return;
                            }
                            currentElement = currentElement.left;
                        }
                        else
                        {
                            if (currentElement.right == null)
                            {
                                currentElement.right = new Node(data);
                                return;
                            }
                            currentElement = currentElement.right;
                        }
                    }
                }
            }
        }

        public void DeleteElement(int data)
        {

        }
    }
}