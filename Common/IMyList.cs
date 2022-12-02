using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IMyList
    {
        void SwitchNodes(Node argFirstNode, Node argSecondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node First();
        void Sort();
        void SortDesc();
    }

    public abstract class SortStrategy
    {
        public abstract void Sort(IMyList list);
        public abstract void SortDesc(IMyList list);
    }
}
