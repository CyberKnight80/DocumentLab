using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentLibrary;

namespace DocumentGUI
{
    public class PredicateElements
    {
        private Predicate<Document> _predicate = delegate (Document a) { return true;  };

        public Predicate<Document> FormPredicateDoc(
            bool eqName,
            bool eqDesc,
            bool eqPrior,
            bool eqDate,
            bool greaterDate,
            bool lowerDate,
            bool lowerEqDate,
            bool greaterEqDate,
            bool eqContent,
            bool eqSignedBy,
            bool isDone,
            bool isAc,

            bool avalName,
            bool avalDesc,
            bool avalPrior,
            bool avalDate,
            bool avalContent,
            bool avalSignedBy,
            bool avalDone,
            bool avalAc,

            string name,
            string desc,
            string prior,
            DateOnly dt,
            string content,
            string signedBy,
            string Done,
            string ad
            )
        {

            if (avalName)
            {
                if (eqName)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && EqualsName(a, name); };
                }
                else
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && NotEqualsName(a, name); };
                }
                  
            }

            if (avalDesc)
            {
                if (eqDesc)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && EqualsDesc(a, desc); };
                }
                else
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && NotEqualsDesc(a, desc); };
                }
                   
            }

            if (avalPrior)
            {
                if (eqPrior)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && EqualsPriority(a, prior); };
                }
                else
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && NotEqualsPriority(a, prior); };
                }
                    
            }

            if (avalDate)
            {
                if (eqDate)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && EqualsDate(a, dt); };
                }

                else if (greaterDate)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && GreaterDate(a, dt); };
                }

                else if (lowerDate)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && LowerDate(a, dt); };
                }

                else if (greaterEqDate)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && GreaterEqualsDate(a, dt); };
                }

                else if (lowerEqDate)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && LowerEqualsDate(a, dt); };
                }

                else
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && NotEqualsDate(a, dt); };
                }
                   
            }

            if (avalContent)
            {
                if (eqContent)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && EqualsContent(a, content); };
                }
                    
                else
                {
                    Predicate<Document> predicateClone = _predicate;
                     this._predicate += delegate (Document a) { return predicateClone(a) && NotEqualsContent(a, content); };
                }
                   
            }

            if (avalSignedBy)
            {
                if (eqSignedBy)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && EqualsSignedBy(a, signedBy); };
                }
                  
                else
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && NotEqualsSignedBy(a, signedBy); };
                }
                    
            }

            if (avalDone)
            {
                if (isDone)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && IsDone(a, Done); };
                }
                    
                else
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && IsNotDone(a, Done); };
                }
                    
            }

            if (avalAc)
            {
                if(isAc)
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && IsAccepted(a, ad); };
                }
                    
                else
                {
                    Predicate<Document> predicateClone = _predicate;
                    this._predicate += delegate (Document a) { return predicateClone(a) && IsNotAccepted(a, ad); };
                }
                    
            }

            return this._predicate;
        }

        bool EqualsName(Document? doc, string? name)
        {
            if(doc is not null && name is not null)
            {
                return doc.Name.Equals(name);
            }

            return false;
        }

        bool NotEqualsName (Document? doc, string? name)
        {
            if (doc is not null && name is not null)
            {
                return !EqualsName(doc, name);
            }
               
            return false;
        }

        bool EqualsDesc(Document? doc, string? desc)
        {
            if (doc is not null && desc is not null)
            {
                if(doc.Description is not null)
                    return doc.Description.Equals(desc);
            }

            return false;
        }

        bool NotEqualsDesc(Document? doc, string? desc)
        {
            if (doc is not null && desc is not null)
                return !EqualsDesc(doc, desc);

            return false;
        }

        bool EqualsPriority(Document? doc, string? pr)
        {
            if (doc is not null && pr is not null)
                return doc.Priority.Equals(pr);

            return false;
        }

        bool NotEqualsPriority(Document? doc, string? pr)
        {
            if (doc is not null && pr is not null)
                return !EqualsPriority(doc, pr);
            return false;
        }

        bool EqualsDate(Document? doc, DateOnly? dt)
        {
            if (doc is not null && dt is not null)
            {
                return dt.Equals(doc.ShelfTime);
            }

            return false;
        }
        bool NotEqualsDate(Document? doc, DateOnly? dt)
        {
            if (doc is not null && dt is not null)
                return !EqualsDate(doc, dt);

            return false;
        }

        bool GreaterDate(Document? doc, DateOnly? dt)
        {
            if (doc is not null && dt is not null)
            {
                return doc.ShelfTime > dt;
            }

            return false;
        }

        bool LowerDate(Document? doc, DateOnly? dt)
        {
            if (doc is not null && dt is not null)
            {
                return doc.ShelfTime < dt;
            }

            return false;
        }

        bool LowerEqualsDate(Document? doc, DateOnly? dt)
        {
            if (doc is not null && dt is not null)
                return !GreaterDate(doc, dt);
            return false;
        }

        bool GreaterEqualsDate(Document? doc, DateOnly? dt)
        {
            if (doc is not null && dt is not null)
                return !LowerDate(doc, dt);
            return false;
        }

        bool EqualsContent(Document? doc, string? content)
        {
           
            if (doc is not null && content is not null)
            {
                if (typeof(Report) == doc.GetType())
                {
                    var document = doc as Report;
                    if (document is not null)
                        return document.Content == content;
                }
                    
                if (typeof(Statement) == doc.GetType())
                {
                    var document = doc as Statement;
                    if(document is not null)
                        return document.Content == content;
                }

                if (typeof(Memo) == doc.GetType())
                {
                    var document = doc as Memo;
                    if (document is not null)
                        return document.Content == content;
                }
            }

            return false; 
        }

        bool NotEqualsContent(Document? doc, string? content)
        {
            if (doc is not null && content is not null)
                return !EqualsContent(doc, content);

            return false;
        }

        bool EqualsSignedBy(Document? doc, string? signedBy)
        {
            if (doc is not null &&signedBy is not null)
            {

                if (typeof(Statement) == doc.GetType())
                {
                    var document = doc as Statement;
                    if (document is not null)
                        return document.SignedBy ==signedBy;
                }
            }

            return false;
        }

        bool NotEqualsSignedBy(Document? doc, string? signedBy)
        {
            if (doc is not null && signedBy is not null)
                return !NotEqualsSignedBy(doc, signedBy);
            return false;
        }

        bool IsDone(Document? doc, string? arg)
        {
            if (doc is not null && arg is not null)
            {
                if (typeof(Memo) == doc.GetType())
                {
                    var document = doc as Memo;
                    if (document is not null)
                        return document.IsDone && arg == "Yes";
                }
            }

            return false;
        }
        
        bool IsNotDone(Document? doc, string? arg)
        {
            if (doc is not null && arg is not null)
                return !IsDone(doc, arg);
            return false;
        }

        bool IsAccepted(Document? doc, string? arg)
        {
            if (doc is not null && arg is not null)
            {
                if (typeof(Report) == doc.GetType())
                {
                    var document = doc as Report;
                    if (document is not null)
                        return document.IsAccepted && arg == "Yes";
                }
            }
            return false;
        }

        bool IsNotAccepted(Document? doc, string? arg)
        {
            if (doc is not null && arg is not null)
                return !IsAccepted(doc, arg);
            return false;
        }
    }
}
