using System.Collections.Generic;
using LinkedLists.Interfaces;

namespace LinkedLists
{
    public class LinkedList<T> : IDimension, ILinkedList<T>
    {
        public int Length { get => NodeList.Count; }
        public List<Node<T>> NodeList { get; private set; }

        public void Add(T element){
            if (Length == 0){
                NodeList.Add(new Node<T>(element, default));
            } else {
                NodeList[^1].Pointer = element;
                NodeList.Add(new Node<T>(element, default));
            }
        }

        public void RemoveAt(int index){
            if (index == 0){
                NodeList.RemoveAt(index);
            } else if(index == NodeList.Count - 1){
                NodeList[index - 1].Pointer = default;
            } else {
                NodeList[index - 1].Pointer = NodeList[index + 1].Element;
                NodeList.RemoveAt(index);
            }
        }

        public override string ToString(){
            var ris = "";
            foreach (var n in NodeList){
                ris += $"({n.Element}|{n.Pointer}) --> ";
            }
            return ris;
        }
    }
}