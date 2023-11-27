using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace DocumentLibrary
{
    //Dumps exception info into log.txt on root folder of program
    public class IntComparator : IComparer<Document>
    {
        int IComparer<Document>.Compare(Document? x, Document y)
        {
            return x.ShelfTime.CompareTo(y.ShelfTime);
        }
    }

    public interface IVelosiped
    {
        public string[] Print();

        public void SortInt();

        public void SortString();

        public void Randomize();
    }

    public class StringComparator : IComparer<Document> 
    {
        int IComparer<Document>.Compare(Document? x, Document y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }


    public class DocumentException : ApplicationException
    {
        public DocumentException()
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                sw.WriteLine("Something is wrong!");
                sw.WriteLine();
            }
        }

        public DocumentException(string message) : base(message + " (Check Avalible priorities in AvaliblePriorities)")
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                sw.WriteLine(message + "(Check Avalible priorities in AvaliblePriorities)");
                sw.WriteLine();
            }
        }

        public DocumentException(string message, Exception inner) : base(message + " (Check Avalible priorities in AvaliblePriorities)", inner)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                sw.WriteLine(message + "(Check Avalible priorities in AvaliblePriorities)");
                sw.WriteLine(inner.InnerException);
                sw.WriteLine(inner.Message);
                sw.WriteLine(inner.StackTrace);
                sw.WriteLine(inner.Source);
                sw.WriteLine(inner.TargetSite);
                sw.WriteLine();
            }
        }
    }

    public interface ICompareDoc : IComparer<Document>
    {
        int IComparer<Document>.Compare(Document? a, Document? b)
        {
            if (a is not null && b is not null)
            {
                if (a.ShelfTime > b.ShelfTime) return 1;
                if (a.ShelfTime < b.ShelfTime) return -1;
                if (a.ShelfTime == b.ShelfTime)
                {
                    if (a.CompareTo(b) > 0) return 1;
                    if (a.CompareTo(b) < 0) return -1;
                }
            }

            return 0;
        }
    }

    public abstract class Document : ICompareDoc, IComparable<Document>, IEquatable<Document>
    {
        #region Fields

        public static readonly IEnumerable<string> AvaliblePriorities = new HashSet<string>
        { "non-priority", "most", "middle", "lowest" };

        private string _priority;

        private DateOnly _shelfTime;

        public string Name;

        public string? Description;

        public string Priority
        {
            get { return _priority; }
            set
            {
                bool b = !AvaliblePriorities.Contains(value);
                if (b)
                    throw new DocumentException("Invalid Inputed Type");
                else _priority = value;
            }
        }

        public DateOnly ShelfTime
        {
            get { return _shelfTime; }
            set { _shelfTime = value; }
        }

        #endregion

        #region Consturctors

        public Document()
        {
            Name = string.Empty;
            Description = null;
            Priority = "non-priority";
            ShelfTime = new DateOnly(1970, 1, 1);
        }

        public Document(string newName)
        {
            Name = newName;
            Description = null;
            Priority = "non-priority";
            ShelfTime = new DateOnly(1970, 1, 1);
        }

        public Document(string newName, string newPriority)
        {
            Name = newName;
            Description = null;
            Priority = newPriority;
            ShelfTime = new DateOnly(1970, 1, 1);
        }

        public Document(string newName, string? newDescription, string newPriority)
        {
            Name = newName;
            Description = newDescription == null ? null : newDescription;
            Priority = newPriority;
            ShelfTime = new DateOnly(1970, 1, 1);
        }

        public Document(string newName, string? newDescription, string newPriority, DateOnly newShelfTime)
        {
            Name = newName;
            Description = newDescription == null ? null : newDescription;
            Priority = newPriority;
            ShelfTime = newShelfTime;
        }

        #endregion

        #region VitualAndAbstractMethods

        public virtual string GetPriority() { return _priority; }

        public virtual DateOnly GetShelfTime() { return _shelfTime; }

        public abstract override string ToString();

        #endregion

        #region Methods
        public static Document[] ReadFromFileAllLines(string path, int count)
        {
            Document[] newArr = new Document[count];

            int iterator = 0;

            string[] fileData = new string[0];

            try
            {
                fileData = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! Check Log");
                using (StreamWriter sw = new StreamWriter("log.txt", true))
                {
                    sw.WriteLine(e.Message);
                    sw.WriteLine(e.Data);
                    sw.WriteLine(e.StackTrace);
                    sw.WriteLine(e.Source);
                    sw.WriteLine();
                }
                throw new DocumentException("File Problem!", e);
            }
            foreach (string item in fileData)
            {
                switch (item)
                {
                    case "Report":
                        Report item1 = new Report();
                        item1.Name = item; iterator++;
                        item1.Description = fileData[iterator]; iterator++;
                        item1.Content = fileData[iterator]; iterator++;
                        string[] param = fileData[iterator].Split();
                        item1.ShelfTime = new DateOnly(int.Parse(param[2]), int.Parse(param[1]), int.Parse(param[0]));
                        item1.IsAccepted = Convert.ToBoolean(fileData[iterator]); iterator++;
                        item1.SignedBy = fileData[iterator]; iterator++;
                        break;
                    case "Statement":
                        Statement item2 = new Statement();
                        item2.Name = item; iterator++;
                        item2.Description = fileData[iterator]; iterator++;
                        item2.Content = fileData[iterator]; iterator++;
                        string[] param1 = fileData[iterator].Split();
                        item2.ShelfTime = new DateOnly(int.Parse(param1[2]), int.Parse(param1[1]), int.Parse(param1[0]));
                        item2.SignedBy = fileData[iterator]; iterator++;
                        break;
                    case "Memo":
                        Memo item3 = new Memo();
                        item3.Name = item; iterator++;
                        item3.Description = fileData[iterator]; iterator++;
                        item3.Content = fileData[iterator]; iterator++;
                        item3.IsDone = Convert.ToBoolean(fileData[iterator]); iterator++;
                        string[] param2 = fileData[iterator].Split();
                        item3.ShelfTime = new DateOnly(int.Parse(param2[2]), int.Parse(param2[1]), int.Parse(param2[0]));
                        break;
                    default:
                        iterator++;
                        break;
                }
            }
            return newArr;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public bool Equals(Document? obj)
        {
            if(obj is null) return false;

            Document other = obj as Document;

            return Priority.Equals(other.Priority) && ShelfTime.Equals(other.ShelfTime) &&
            Description.Equals(other.Description) && Name.Equals(other.Name);
        }

        public int CompareTo(Document? other)
        {
            return String.Compare(this.GetPriority(), other.GetPriority());
        }

        #endregion

        #region Operators

        public static bool operator ==(Document left, Document right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Document left, Document right)
        {
            return !left.Equals(right);
        }

        public static bool operator >(Document left, Document right)
        {
            if (left.ShelfTime > right.ShelfTime) return true;
            return false;
        }

        public static bool operator <(Document left, Document right)
        {
            if (left.ShelfTime < right.ShelfTime) return true;
            return false;
        }

        public static bool operator >=(Document left, Document right)
        {
            if (left.ShelfTime >= right.ShelfTime) return true;
            return false;
        }

        public static bool operator <=(Document left, Document right)
        {
            if (left.ShelfTime <= right.ShelfTime) return true;
            return false;
        }

        #endregion
    }

    public class Statement : Document
    {
        #region Fields
        public string Content;

        public string SignedBy;

        #endregion

        #region Constructors
        public Statement() : base()
        {
            Content = "There Are No Content";

            SignedBy = "CEO Tesla Motors, Elon";
        }
        public Statement(string name) : base(name)
        {
            Content = "There Are No Content";

            SignedBy = "CEO Tesla Motors, Elon";
        }

        public Statement(string newName, string newPriority) : base(newName, newPriority)
        {
            Content = "There Are No Content";

            SignedBy = "CEO Tesla Motors, Elon";
        }

        public Statement(string newName, string? newDescription, string newPriority) : base(newName, newDescription, newPriority)
        {
            Content = "There Are No Content";

            SignedBy = "CEO Tesla Motors, Elon";
        }

        public Statement(string newName, string? newDescription, string newPriority, DateOnly newShelfTime) : base(newName, newDescription, newPriority, newShelfTime)
        {
            Content = "There Are No Content";

            SignedBy = "CEO Tesla Motors, Elon";
        }

        public Statement(string newName, string? newDescription, string newPriority, DateOnly newShelfTime, string newContent) : base(newName, newDescription, newPriority, newShelfTime)
        {
            Content = newContent;

            SignedBy = "CEO Tesla Motors, Elon";
        }

        public Statement(string newName, string? newDescription, string newPriority, DateOnly newShelfTime, string newContent, string newSigned) : base(newName, newDescription, newPriority, newShelfTime)
        {
            Content = newContent;

            SignedBy = newSigned;
        }

        #endregion

        public override string ToString()
        {
            return $"{Name} {Description} {Priority} {SignedBy} {ShelfTime.Day} {ShelfTime.Month} {ShelfTime.Year}\n{Content}";
        }
    }

    public class Memo : Document
    {
        #region Fields

        public string Content;

        public bool IsDone;

        #endregion

        #region Constructors
        public Memo() : base()
        {
            Content = string.Empty;

            IsDone = false;
        }

        public Memo(string newName) : base(newName)
        {
            Content = string.Empty;

            IsDone = false;
        }

        public Memo(string newName, string newPriority) : base(newName, newPriority)
        {
            Content = string.Empty;

            IsDone = false;
        }

        public Memo(string newName, string? newDescription, string newPriority) : base(newName, newDescription, newPriority)
        {
            Content = string.Empty;

            IsDone = false;
        }

        public Memo(string newName, string? newDescription, string newPriority, DateOnly newShelfTime) : base(newName, newDescription, newPriority, newShelfTime)
        {
            Content = string.Empty;

            IsDone = false;
        }

        public Memo(string newName, string? newDescription, string newPriority, DateOnly newShelfTime, string newContent) : base(newName, newDescription, newPriority, newShelfTime)
        {
            Content = newContent;

            IsDone = false;
        }

        public Memo(string newName, string? newDescription, string newPriority, DateOnly newShelfTime, string newContent, bool newIsDone) : base(newName, newDescription, newPriority, newShelfTime)
        {
            Content = newContent;

            IsDone = newIsDone;
        }

        #endregion

        public override string ToString()
        {
            return $"{Name} {Description} {Priority} {IsDone} {ShelfTime.Day} {ShelfTime.Month} {ShelfTime.Year}\n{Content}";
        }
    }

    public class Report : Statement
    {
        public bool IsAccepted;

        #region Constructors

        public Report() : base()
        {
            IsAccepted = false;
        }

        public  Report(string newName) : base(newName)
        {
            IsAccepted = false;
        }

        public  Report(string newName, string newPriority) : base(newName, newPriority)
        {
            IsAccepted = false;
        }

        public  Report(string newName, string? newDescription, string newPriority) : base(newName, newDescription, newPriority)
        {
            IsAccepted = false;
        }

        public  Report(string newName, string? newDescription, string newPriority, DateOnly newShelfTime) : base(newName, newDescription, newPriority, newShelfTime)
        {
            IsAccepted = false;
        }

        public  Report(string newName, string? newDescription, string newPriority, DateOnly newShelfTime, bool newIsAccepted) : base(newName, newDescription, newPriority, newShelfTime)
        {
            IsAccepted = newIsAccepted;
        }

        #endregion

        public override string GetPriority()
        {
            return base.GetPriority() + $" {IsAccepted}";
        }

        public override string ToString()
        {
            return base.ToString() + $" Is Accepted: {IsAccepted}";
        }
    }

    public class DocumentList : IEnumerable<Document>, IVelosiped
    {
        private List<Document> _list;

        #region Constructors

        public DocumentList()
        {
            this._list = new List<Document>();
        }

        public DocumentList(IEnumerable<Document> enums)
        {
            this._list = new List<Document>();

            foreach (Document val in enums)
            {
                this._list.Add(val);
            }
        }

        public DocumentList(Int32 val)
        {
            this._list = new List<Document>(val);
        }

        #endregion

        #region Properties

        public int Capacity
        {
            get { return this._list.Capacity; }
            set { }
        }

        public int Count
        {
            get { return this._list.Count; }
            set { }
        }

        public Document this[int index] 
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        #endregion

        #region Methods

        public void Add(Document val)
        {
            _list.Add(val);
        }

        public void AddRange(IEnumerable<Document> val) 
        { 
            foreach(Document val1 in val)
            {
                _list.Add(val1);
            }
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<Document> AsReadOnly()
        {
            return _list.AsReadOnly();
        }

        public int BinarySearch(int index, int count, Document item, System.Collections.Generic.IComparer<Document>? comparer)
        {
            return _list.BinarySearch(index, count, item, comparer);
        }

        public int BinarySearch(Document item, System.Collections.Generic.IComparer<Document>? comparer)
        {
            return _list.BinarySearch(item, comparer);
        }

        public int BinarySearch(Document item)
        {
            return _list.BinarySearch(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public void CopyTo(int index, Document[] array, int arrayIndex, int count)
        {
            for(int i = index; i < count; i++)
            {
                array[arrayIndex++] = _list[i];
            }
        }

        public void CopyTo(Document[] array)
        {
            array = new Document[_list.Count];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = _list[i];
            }
        }

        public void CopyTo(Document[] array, int arrayIndex)
        {
            int count = 0;

            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = _list[count++]; 
            }
        }
        public bool Contains(Document val)
        {
            if (_list.Contains(val)) return true;

            return false;
        }

        public virtual bool Equals(DocumentList obj)
        {
            if (this.Count != obj.Count) return false;

            for(int i = 0; i < obj.Count; i++)
            {
                if (!this[i].Equals(obj[i])) return false;
            }

            return false;
        }

        public bool Exists(Predicate<Document> match)
        {
            return _list.Exists(match);
        }

        public Document? Find(Predicate<Document> predicate)
        {
            return _list.Find(predicate);
        }

        public DocumentList FindAll(Predicate<Document> predicate)
        {
            DocumentList findList = new DocumentList();

            findList._list = _list.FindAll(predicate);

            return findList;
        }

        public int FindIndex(int startIndex, int count, Predicate<Document> match)
        {
            return _list.FindIndex(startIndex, count, match);
        }

        public int FindIndex(int startIndex, Predicate<Document> match)
        {
            return _list.FindIndex(startIndex, match);
        }

        public int FindIndex(Predicate<Document> match)
        {
            return _list.FindIndex(match);
        }

        public Document? FindLast(Predicate<Document> match)
        {
            return _list.FindLast(match);
        }

        public int FindLastIndex(int startIndex, int count, Predicate<Document> match)
        {
            return _list.FindLastIndex(startIndex, count, match);
        }

        public int FindLastIndex(int startIndex, Predicate<Document> match)
        {
            return _list.FindLastIndex(startIndex, match);
        }

        public int FindLastIndex(Predicate<Document> match)
        {
            return _list.FindLastIndex(match);
        }

        public void ForEach(Action<Document> action)
        {
            _list.ForEach(action);
        }

        public System.Collections.Generic.List<Document>.Enumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public virtual int GetHashCode()
        {
            return _list.GetHashCode();
        }

        public DocumentList GetRange(int index, int count)
        {
            DocumentList values = new DocumentList();

            while(count > 0)
            {
                values.Add(this[index]);

                index++;
            }

            return values;
        }

        public Type GetType()
        {
            return typeof(DocumentList);
        }

        public int IndexOf(Document item)
        {
            return _list.IndexOf(item);
        }

        public int IndexOf(Document item, int index)
        {
            return _list.IndexOf(item, index);
        }

        public int IndexOf(Document item, int index, int count)
        {
            return _list.IndexOf(item, index, count);
        }

        public void Insert(int index, Document item)
        {
            _list.Insert(index, item);
        }

        public void InsertRange(int index, System.Collections.Generic.IEnumerable<Document> collection)
        {
            _list.InsertRange(index, collection);
        }

        public int LastIndexOf(Document item)
        {
            return _list.LastIndexOf(item);
        }

        public int LastIndexOf(Document item, int index)
        {
            return _list.LastIndexOf(item, index);
        }

        public int LastIndexOf(Document item, int index, int count)
        {
            return _list.LastIndexOf(item, index, count);
        }

        protected object MemberwiseClone()
        {
            return MemberwiseClone();
        }

        public string[] Print()
        {
            string[] strings = new string[this.Count];


            int i = 0;
            foreach (Document val in this)
            {
                strings[i++] = val.ToString();
            }

            return strings;
        }
        
        public void Randomize()
        {
            int n = 3;

            _list = new List<Document>();

            Random r = new Random();

            string[] abc = {"A", "B", "C"};

            for(int i = 0; i < n; i++)
            {
                int arg = (int)r.Next(0,3);

                switch(arg)
                {
                    case 0:
                        DateOnly date = new DateOnly(
                            r.Next(2000,2024),
                            r.Next(1,13),
                            r.Next(1,29)
                            );

                        Memo doc1 = new Memo(
                            abc[r.Next(0, abc.Length)],
                            "Lol!",
                            "non-priority",
                            date
                            );
                        _list.Add(doc1);
                        break;
                    case 1:
                        DateOnly date1 = new DateOnly(
                            r.Next(2000, 2024),
                            r.Next(1, 13),
                            r.Next(1, 29)
                            );

                        Statement doc2 = new Statement(
                            abc[r.Next(0, abc.Length)],
                            "Lol!",
                            "non-priority",
                            date1
                            );
                        _list.Add(doc2);
                        break;
                    case 2:
                        DateOnly date2 = new DateOnly(
                            r.Next(2000, 2024),
                            r.Next(1, 13),
                            r.Next(1, 29)
                            );

                        Report doc3 = new Report(
                            abc[r.Next(0, abc.Length)],
                            "Lol!",
                            "non-priority",
                            date2
                            );
                        _list.Add(doc3);
                        break;
                }
            }
        }

        public bool Remove(Document item)
        {
            return _list.Remove(item);
        }

        public int RemoveAll(Predicate<Document> match)
        {
            return _list.RemoveAll(match);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public void RemoveRange(int index, int count)
        {
            _list.RemoveRange(index, count);
        }
        public void Reverse()
        {
            _list.Reverse();
        }

        public void Reverse(int index, int count)
        {
            _list.Reverse(index, count);
        }

        public void Sort()
        {
            _list.Sort();
        }

        public void Sort(Comparison<Document> comparison)
        {
            _list.Sort(comparison);
        }

        public void Sort(System.Collections.Generic.IComparer<Document>? comparer)
        {
            _list.Sort(comparer);
        }

        public void Sort(int index, int count, System.Collections.Generic.IComparer<Document>? comparer)
        {
            _list.Sort(index, count, comparer);
        }

        public void SortInt()
        {
            IComparer<Document> comparer = new IntComparator();
            _list.Sort(comparer);
        }

        public void SortString()
        {
            IComparer<Document> comparer = new StringComparator();
            _list.Sort(comparer);
        }

        public Document[] ToArray()
        {
            return _list.ToArray();
        }

        public virtual string? ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in _list) 
            {
                sb.Append(item + " ");
            }

            return sb.ToString();
        }

        public void TrimExcess()
        {
            _list.TrimExcess();
        }

        public bool TrueForAll(Predicate<Document> match)
        {
            return _list.TrueForAll(match);
        }

        IEnumerator<Document> IEnumerable<Document>.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        #endregion
    }
}

    
   
