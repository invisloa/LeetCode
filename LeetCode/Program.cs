using System.Linq;

ListNode L1 = new ListNode(2);
ListNode node2 = new ListNode(4);
ListNode node3 = new ListNode(3);
L1.next = node2;
node2.next = node3;

ListNode L2 = new ListNode(5);
ListNode node22 = new ListNode(6);
ListNode node33 = new ListNode(4);
L2.next = node22;
node22.next = node33;


AddTwoNumbers(L1 , L2);

 ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
	string l1number = l1.val.ToString();
	string l2number = l2.val.ToString();
	while (l1.next != null)
    {
		l1number += l1.next.val.ToString();
		l1 = l1.next;
    }
	while (l2.next != null) 
	{
		l2number += l2.next.val.ToString();
		l2 = l2.next;

	}
	long summedNumbers = long.Parse(new string(l1number.Reverse().ToArray()))+ long.Parse(new string(l2number.Reverse().ToArray()));
	var nodesList = summedNumbers.ToString().Select(x => x.ToString()).Reverse().ToArray();

	ListNode returnHeadNode= null;
	ListNode curr = null;

	for (int i = 0; i < nodesList.Length; i++)
	{
		ListNode newNode = new ListNode(int.Parse(nodesList[i]));

		if (returnHeadNode == null)
		{
			returnHeadNode = newNode;
			curr = newNode;
		}
		else
		{
			curr.next = newNode;
			curr = curr.next;
		}
	}
	return returnHeadNode;
}
public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}
