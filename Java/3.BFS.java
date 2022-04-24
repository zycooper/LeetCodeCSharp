/*BFS: Breadth First Search*/

import java.util.*;

class TreeNode {
  int val;
  TreeNode left;
  TreeNode right;

  TreeNode(int x) {
    val = x;
  }
};

class LevelOrderTraversal {
  public static List<List<Integer>> traverse(TreeNode root) {

    List<List<Integer>> result = new ArrayList<List<Integer>>();
      if(root == null)
      {
          return result;
      }

    //queue is abstract, cannot be initialted, so var queue with linkedlist
    Queue<TreeNode> queue = new LinkedList<>();
    queue.offer(root);
    while(!queue.isEmpty())
    {
        //be caution with this line, reset the int of size every loop, if you use queue.size() instead may not be correct!
        int currentLevelSize = queue.size();
        List<Integer> currentLevelList = new ArrayList<Integer>(currentLevelSize);

        for(int index_currentLevelNodes = 0; index_currentLevelNodes < currentLevelSize; index_currentLevelNodes++)
        {
            //every time enter this loop, the queue is full of current level nodes and no father nodes
            //pop the queue and insert the value into current level list
            TreeNode currentNode = queue.poll();

            currentLevelList.add(currentNode.val);

            //offer the children nodes of current node to queue
            if(currentNode.left != null)
            {
                queue.offer(currentNode.left);
            }

            if(currentNode.right != null)
            {
                queue.offer(currentNode.right);
            }
            //till this step, the current level is re-freashed with all the childre nodes, all father nodes have been poll out
        }

        result.add(currentLevelList);
    }

    return result;
  }

  public static void main(String[] args) {
    TreeNode root = new TreeNode(12);
    root.left = new TreeNode(7);
    root.right = new TreeNode(1);
    root.left.left = new TreeNode(9);
    root.right.left = new TreeNode(10);
    root.right.right = new TreeNode(5);
    List<List<Integer>> result = LevelOrderTraversal.traverse(root);
    System.out.println("Level order traversal: " + result);
  }
}
