using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class AddListNodeNumbers
	{
		ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			int carry = 0;
			ListNode head = new ListNode(0);
			ListNode curr = head;

			while (l1 != null || l2 != null || carry != 0)
			{
				int sum = carry;

				if (l1 != null)
				{
					sum += l1.val;
					l1 = l1.next;
				}

				if (l2 != null)
				{
					sum += l2.val;
					l2 = l2.next;
				}

				carry = sum / 10;
				sum = sum % 10;

				curr.next = new ListNode(sum);
				curr = curr.next;
			}

			return head.next;
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

	}
}
