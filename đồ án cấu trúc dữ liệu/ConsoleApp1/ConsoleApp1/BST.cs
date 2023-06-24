using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    public class BST
    {
        public Node Root { get; set; }
        //=================== Insert ===================   
        public bool Insert(DanhBa value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if ((value.GetNickname().CompareTo(after.Data.GetNickname())) < 0) 
                    after = after.LeftNode;
                else if ((value.GetNickname().CompareTo(after.Data.GetNickname())) > 0)
                    after = after.RightNode;
                else
                    return false;
            }
            Node newNode = new Node();
            newNode.Data = value;
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if ((value.GetNickname()).CompareTo(before.Data.GetNickname()) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }        
        //================== Output ==================
        public void Output(Node parent)
        {
            if (parent != null)
            {
                Output(parent.LeftNode);
                Console.WriteLine("                                           " + parent.Data);
                Output(parent.RightNode);
            }
        }                
        public DanhBa MinValueOfNode(Node node)
        {
            DanhBa minv = node.Data;
            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return minv;
        }
        //============= Remove ===============
        public void Remove(string value)
        { this.Root = Remove(this.Root, value); }
        public Node Remove(Node parent, string name)
        {
            if (parent == null) return parent;

            if (name.ToLower().CompareTo(parent.Data.GetNickname().ToLower()) < 0)
            {
                parent.LeftNode = Remove(parent.LeftNode, name);

            }
            else
            {
                if (name.ToLower().CompareTo(parent.Data.GetNickname().ToLower()) > 0)
                {
                    parent.RightNode = Remove(parent.RightNode, name);
                }
                else { 
                    if (parent.LeftNode == null) return parent.RightNode;
                    else if (parent.RightNode == null) return parent.LeftNode;                   
                    parent.Data = MinValueOfNode(parent.RightNode);
                    parent.RightNode = Remove(parent.RightNode, parent.Data.GetNickname());
                }
            }
            return parent;
        }
        //======== FindName =========
        public Node FindName(string key)
        { return this.FindName(key, this.Root); }

        public Node FindName(string key, Node parent)
        {
            if (parent != null)
            {
                if (key.ToLower() == parent.Data.GetNickname().ToLower()) return parent;
                if (key.ToLower().CompareTo(parent.Data.GetNickname().ToLower()) < 0)
                    return FindName(key, parent.LeftNode);
                else
                    return FindName(key, parent.RightNode);
            }
            return null;
        }
        //======== FindId =========
        public void FindId(Node parent, string id)
        {
            if (parent != null)
            {
                
                FindId(parent.LeftNode, id);
                if (parent.Data.GetId().ToLower().Contains((id.ToLower())))
                {
                    Console.WriteLine($"{parent.Data}|    {parent.Data.GetFaceBook(),25}|    {parent.Data.GetEmail(),25}|    {parent.Data.GetSex(),4}");
                }                
                FindId(parent.RightNode, id);

            }
        }
        //======== FindPhoneNumber =========
        public void FindPhonenumber(Node parent, string phonenumber)
        {
            if (parent != null)
            {
                FindPhonenumber(parent.LeftNode, phonenumber);
                if (parent.Data.GetPhonenumber().Contains(phonenumber))
                {
                    Console.WriteLine($"{parent.Data}|    {parent.Data.GetFaceBook(),25}|    {parent.Data.GetEmail(),25}|    {parent.Data.GetSex(),4}");
                }                
                FindPhonenumber(parent.RightNode, phonenumber);
            }
        }

        //======== Sexfilter ========= 
        public void Sexfilter(Node parent, string sex)
        {
            if (parent != null)
            {
                
                Sexfilter(parent.LeftNode, sex);
                if (parent.Data.GetSex().ToLower() == sex.ToLower())
                {
                    Console.WriteLine($"{parent.Data}|    {parent.Data.GetFaceBook(),25}|    {parent.Data.GetEmail(),25}|    {parent.Data.GetSex(),4}");
                }
                Sexfilter(parent.RightNode, sex);
            }
        }
        //======== Birthfilter =========
        public void BirthFilter(Node parent, string birth)
        {

            if (parent != null)
            {
                BirthFilter(parent.LeftNode, birth);

                if (parent.Data.GetBirth().Contains(birth))
                {
                    Console.WriteLine($"{parent.Data}|    {parent.Data.GetFaceBook(),25}|    {parent.Data.GetEmail(),25}|    {parent.Data.GetSex(),4}");
                }
                BirthFilter(parent.RightNode, birth);
            }
        }
        //======== DeleteTree =========
        public void DeleteTree(Node node)
        {
             Root = null;
        }
        //======== DeleteAllTree =========
        public void DeleteAllTree(Node node)
        {
            DeleteTree(node);
            node = null;
            Console.WriteLine("Danh bạ rỗng ... !");
        }
        //======== CountNode =========
        public int CountNode(Node parent)
        {
            if (parent == null) return 0;
            else return (CountNode(parent.LeftNode) + CountNode(parent.RightNode)) + 1;
        }
    }
}
