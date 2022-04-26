class PathWithGivenSequence {
  public static boolean findPath(TreeNode root, int[] sequence) {
    // TODO: Write your code here

    return findPathRecursion(root, sequence, 0);
  }
  private static boolean findPathRecursion(TreeNode root, int[] sequence, int cur_index)
  {
      if(root == null )
      {
          return false;
      }

      //break/end point
      if(root.left == null && root.right == null && cur_index == sequence.length - 1)
      {
          return true;
      }

      return  findPathRecursion(root.left, sequence,cur_index + 1) ||
          findPathRecursion(root.right,sequence,cur_index + 1);;
  }

  public static void main(String[] args) {
    TreeNode root = new TreeNode(1);
    root.left = new TreeNode(0);
    root.right = new TreeNode(1);
    root.left.left = new TreeNode(1);
    root.right.left = new TreeNode(6);
    root.right.right = new TreeNode(5);

    System.out.println("Tree has path sequence: " + PathWithGivenSequence.findPath(root, new int[] { 1, 0, 7 }));
    System.out.println("Tree has path sequence: " + PathWithGivenSequence.findPath(root, new int[] { 1, 1, 6 }));
  }