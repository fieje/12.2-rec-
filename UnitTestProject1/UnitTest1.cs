using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program12_2Rec;

namespace Program12_2Rec.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestSplitList_PositiveAndNegativeListsAreCorrect()
        {
            ListNode head = new ListNode(1,
                new ListNode(-2,
                    new ListNode(3,
                        new ListNode(-4,
                            new ListNode(5)
                        )
                    )
                )
            );

            ListNode positiveList;
            ListNode negativeList;

            Solution.SplitList(head, out positiveList, out negativeList);

            Assert.AreEqual("1 3 5", ConvertToString(positiveList), "Positive list is not correct");
            Assert.AreEqual("-2 -4", ConvertToString(negativeList), "Negative list is not correct");
        }

        private string ConvertToString(ListNode head)
        {
            string result = "";
            while (head != null)
            {
                result += head.Value + " ";
                head = head.Next;
            }
            return result.Trim();
        }
    }
}
