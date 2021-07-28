using Pioneer.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pioneer.Class
{
    public class DAO
    {

        public abstract partial class MAINCONTEXT1
        {
            public Linq_dbDataContext db = new Linq_dbDataContext();
            public object datas;

            public partial interface MAIN
            {
                void insert();
                void delete();
                void update();
            }

            public class tb_member
            {
                internal partial class SurroundingClass : MAINCONTEXT1
                {
                    public MEMBER fields = new MEMBER();
                    private List<MEMBER> _Details = new List<MEMBER>();
                    public List<MEMBER> Details
                    {
                        get
                        {
                            return _Details;
                        }

                        set
                        {
                            _Details = value;
                        }
                    }

                    public void AddDetails()
                    {
                        Details.Add(fields);
                        fields = new MEMBER();
                    }

                    public void delete()
                    {
                        db.MEMBERs.DeleteOnSubmit(fields);
                        db.SubmitChanges();
                    }

                    public void insert()
                    {
                        db.MEMBERs.InsertOnSubmit(fields);
                        db.SubmitChanges();
                    }

                    public void update()
                    {
                        db.SubmitChanges();
                    }

                    public void Getdata_byid(int id)
                    {
                        datas = (from q in db.MEMBERs
                                 where q.IDA == id
                                 select q);

                        //foreach (MEMBER fields in datas.GetType().GetProperties())
                        //{
                        //    AddDetails();
                        //}
                    }

                }


            }

        }


    }
}