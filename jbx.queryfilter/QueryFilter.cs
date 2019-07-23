using System;
using System.Collections.Generic;
using System.Text;

namespace jbx.queryfilter
{
    public class QueryFilter
    {
        private int _page;
        public int page {
            get
            {
                return this._page;
            }
            set {
                this.page = value;
            }
        }

        private int _pageSize;
        public int pageSize {
            get {
                return this._pageSize;
            }
            set
            {
                this._pageSize = value;
            }
        }

        private string _sort;
        public string sort {
            get {
                return this._sort;
            } set {
                var val = value;
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    val = "id:desc";
                }
                this._sort = val;
            }
        }

        private string _query;
        public string query {
            get {
                return this._query;
            } set {
                var val = value;
                if (string.IsNullOrWhiteSpace(val) || string.IsNullOrEmpty(val))
                {
                    val = "";
                }
                this._query = val;
            }
        }
    }
}
