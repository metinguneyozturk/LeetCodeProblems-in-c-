
public class Solution {
    public string GcdOfStrings(string s1, string s2) {
        int l1 = s1.Length;
        int l2 = s2.Length;
        
        if(l2 > l1)
            (s1, s2) = (s2, s1);
           for(int i = s2.Length; i > 0; i--)
        {
            string max = s2.Substring(0, i);
            string t1 = s1.Replace(max, "");
            string t2 = s2.Replace(max, "");
            if(string.IsNullOrEmpty(t1) && string.IsNullOrEmpty(t2))
                return max;
        }
     
        
        return string.Empty;
    }
    public int[] TwoSum(int[] nums, int target) {
     int[] ans = new int[2];    
    var sortedarray=nums.OrderBy(x=>x).ToArray();
     int i=0;
     int k = nums.Length-1;
     
    while(true)
    
    {
        
        if(sortedarray[i]+sortedarray[k]>target)
        {
            k--;
        }
        else if(sortedarray[i]+sortedarray[k]<target)
        {
            i++;
        }
        else if(sortedarray[i]+sortedarray[k]==target)
        {
            var x =Array.IndexOf(nums,sortedarray[i]);
            nums[x]=31;
            var y = Array.IndexOf(nums, sortedarray[k]);
            nums[y]=31;

            ans[0]=x;
           
            ans[1]=y;
            break;
        }

    }
    
    return ans;}

       public int RomanToInt(string s) {
        s.ToCharArray();
        int sum =0;
        int[] intformat = new int[s.Length];
        for(int i=0; i<s.Length; i++ )
        {
            if(s[i]=='I'){
                intformat[i]=1;
            }
            else if(s[i]=='V'){
                intformat[i]=5;
            }
            else if(s[i]=='X'){
                intformat[i]=10;
            }
            else if(s[i]=='L'){
                intformat[i]=50;
            }
            else if(s[i]=='C'){
                intformat[i]=100;
            }
            else if(s[i]=='D'){
                intformat[i]=500;
            }
            else if(s[i]=='M'){
                intformat[i]=1000;
            }
        }
        
        for(int i=0; i<intformat.Length; i++){
            if(i==intformat.Length-1){
                sum=sum+intformat[i];
            }
            else if(intformat[i]>=intformat[i+1]){
                sum=sum+intformat[i];
            }
            else if(intformat[i]<intformat[i+1]){
                sum=sum-intformat[i];
            }
        }
        

        
   return sum; }
   public bool IsAlienSorted(string[] words, string order) {

    //Çözüm Yanlış
     bool ans = true;
    for(int i=0; i<words.Count(); i++){
        if(i==words.Count()-1){return ans;}
        for(int k=0; k<words[i].ToCharArray().Length; k++)
            {
                var x = Array.IndexOf(order.ToCharArray(),words[i].ToCharArray()[k]);
                try{
                var y = Array.IndexOf(order.ToCharArray(),words[i+1].ToCharArray()[k]);
                if(x<y){return ans=true;}
                if(x>y){return ans=false;}
                }
                catch(Exception e){
                    return ans=false;
                }

    
            }
    }

return ans;}

    public bool IsValid(string s) {
        //Review

        // Get ready initial state (enforce element type)
        var k = new Stack<char>();
        // Evaluate each character for potential mismatch 
        foreach(char c in s) {
            // Push closing round bracket onto the stack
            if (c == '(') { k.Push(')'); continue; }
            // Push closing curly bracket onto the stack
            if (c == '{') { k.Push('}'); continue; }
            // Push closing square bracket onto the stack
            if (c == '[') { k.Push(']'); continue; }
            // Look out for imbalanced strings or mismatches
            if (k.Count == 0 || c != k.Pop()) return false;
        }

        // Empty stack means string is valid and invalid otherwise
        return k.Count == 0;
    }
        
      public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;
        }


    public int SingleNumber(int[] nums) {
    //Works but not in Linear Time
    //     int ans=0;
    //     for(int i=0; i<nums.Length; i++)
    //     {    
    //     if(nums.Count(p=> p==nums[i])==1)
    //     {
    //         ans=nums[i];
    //     }
        
    //     }


    // return ans;
    int res = nums[0];

	for (int i = 1; i < nums.Length; i++)
		//res ^= nums[i];
        res= res^nums[i];
        Console.WriteLine(res);

	return res;
    }


//  public class ListNode {
//      public int val;
//       public ListNode next;
//       public ListNode(int x) {
//           val = x;
//           next = null;
//       }
//   }
//   public bool HasCycle(ListNode head) {
//     //Didn't get the problem
//         bool ans = true;
//         if(head.next==null )
//         {
//             ans=false;
//         }


//    return ans;}
//================================================================================
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 public IList<int> PreorderTraversal(TreeNode root) {
    IList<int> ans = new List<int>();
    preorder(ans, root);
 
   
        
    return ans;}

 
    public void preorder(IList<int> list,TreeNode node)
    {

    if(node==null) return;

    list.Add(node.val);
    preorder(list,node.left);
    preorder(list,node.right);
   
    }

///////////////////////////=========================================
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> ans = new List<int>();
        postorder(ans,root);
        return ans;
    }

    public void postorder(IList<int> list,TreeNode node)
    {

    if(node==null) return;

   
    postorder(list,node.left);
    postorder(list,node.right);
     list.Add(node.val);
   
    }
    //======================================================
    //extra 0 node
  
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
      public ListNode SortList(ListNode head) {
        var anslist = new List<int>();
        var ansnode = new ListNode();
        if(head == null) return head;
        ListNodeToList(anslist,head);
        //anslist.Sort();
        ListToNodeList(anslist,ansnode);
        return ansnode;
      
        
    }
    public void ListNodeToList(List<int> list, ListNode inputnode)
    {
        if(inputnode==null) return;
        
        list.Add(inputnode.val);
        
        ListNodeToList(list, inputnode.next);
    }
    public void ListToNodeList(List<int> list, ListNode initNode)
    {
        if(list.Count()<1){return;}
        initNode.val=list.ElementAt(0);
        list.RemoveAt(0);
        var nextNode = new ListNode();
        initNode.next = nextNode;
        ListToNodeList(list, nextNode );
    }
    

//=======================================================
   
    public int LengthOfLastWord(string s) {
        int ans=0;
        if(s.Length<=2) return ans=1;
        for(int i = s.Length-1; i>=0; i--)
        {
            while(s[i]!=' ')
            {
                ans++;
                if(i==0) return ans;
                i--;
               
            }
             if(ans!=0)
            {
            return ans;
            }


           if(ans==0 && i==0) return ans=s.Length-1;
        }


        
    return ans;
    }
    //===============================================


    public int CountOdds(int low, int high) {
        int ans=0;
        for(int i =low; i<=high; i++)
        {
            if(int.IsOddInteger(i)) ans++;
        
        }
        return ans;
        
        
    }
     public int NumIdenticalPairs(int[] nums) {
     int ans =0;
     for(int i=0; i<nums.Length; i++)
    {
        for(int k=nums.Length-1; k>i; k-- )
        {
            if(nums[i]==nums[k]){
                if(i<k) ans++;
            }
        }
        

    }
    return ans;}

        public int NumWaterBottles(int numBottles, int numExchange) {
        int total = numBottles;
        int empty = numBottles;

        while(empty >= numExchange)
        {
            empty -= numExchange;
            total++;
            empty++; 
        }

        return total;
    }


     public int[] BuildArray(int[] nums) {
        int[] ans = new int[nums.Length];

        for(int i=0; i<nums.Length; i++)
          {
            ans[i]=nums[nums[i]];


        }
        
   return ans; }

    public int[] GetConcatenation(int[] nums) {
     int[] ans = new int[nums.Length*2];
     int i=0;
     int k=0;
     while(i<nums.Length*2)
     {
        ans[i]=nums[k];
        i++;
        if(k==nums.Length-1){
            k=0;}
        else if(k<nums.Length-1)
        {
            k++;
        }
     }
     

    return ans;}


   


   public bool IsThree(int n) {
    int ans=0;
    for(int i=n; i>0; i--)
    {
        if(n%i==0)
        {
            ans++;
        }
    }
    return ans==3;
        
    }

 
   public int FindMiddleIndex(int[] nums) {
        
    }  

}




