﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace book_shop
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="store")]
	public partial class booksDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    partial void Insertbookorder(bookorder instance);
    partial void Updatebookorder(bookorder instance);
    partial void Deletebookorder(bookorder instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void Insertcounty(county instance);
    partial void Updatecounty(county instance);
    partial void Deletecounty(county instance);
    #endregion
		
		public booksDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["storeConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public booksDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public booksDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public booksDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public booksDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
		
		public System.Data.Linq.Table<bookorder> bookorders
		{
			get
			{
				return this.GetTable<bookorder>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<county> counties
		{
			get
			{
				return this.GetTable<county>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[order]")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderid;
		
		private string _username;
		
		private System.DateTime _orderdate;
		
		private string _orderaddress1;
		
		private string _orderaddress2;
		
		private string _ordertown;
		
		private string _orderpostcode;
		
		private System.Nullable<int> _countyid;
		
		private bool _orderpaid;
		
		private bool _ordersent;
		
		private EntitySet<bookorder> _bookorders;
		
		private EntityRef<county> _county;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderidChanging(int value);
    partial void OnorderidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnorderdateChanging(System.DateTime value);
    partial void OnorderdateChanged();
    partial void Onorderaddress1Changing(string value);
    partial void Onorderaddress1Changed();
    partial void Onorderaddress2Changing(string value);
    partial void Onorderaddress2Changed();
    partial void OnordertownChanging(string value);
    partial void OnordertownChanged();
    partial void OnorderpostcodeChanging(string value);
    partial void OnorderpostcodeChanged();
    partial void OncountyidChanging(System.Nullable<int> value);
    partial void OncountyidChanged();
    partial void OnorderpaidChanging(bool value);
    partial void OnorderpaidChanged();
    partial void OnordersentChanging(bool value);
    partial void OnordersentChanged();
    #endregion
		
		public order()
		{
			this._bookorders = new EntitySet<bookorder>(new Action<bookorder>(this.attach_bookorders), new Action<bookorder>(this.detach_bookorders));
			this._county = default(EntityRef<county>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int orderid
		{
			get
			{
				return this._orderid;
			}
			set
			{
				if ((this._orderid != value))
				{
					this.OnorderidChanging(value);
					this.SendPropertyChanging();
					this._orderid = value;
					this.SendPropertyChanged("orderid");
					this.OnorderidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderdate", DbType="DateTime NOT NULL")]
		public System.DateTime orderdate
		{
			get
			{
				return this._orderdate;
			}
			set
			{
				if ((this._orderdate != value))
				{
					this.OnorderdateChanging(value);
					this.SendPropertyChanging();
					this._orderdate = value;
					this.SendPropertyChanged("orderdate");
					this.OnorderdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderaddress1", DbType="NVarChar(MAX)")]
		public string orderaddress1
		{
			get
			{
				return this._orderaddress1;
			}
			set
			{
				if ((this._orderaddress1 != value))
				{
					this.Onorderaddress1Changing(value);
					this.SendPropertyChanging();
					this._orderaddress1 = value;
					this.SendPropertyChanged("orderaddress1");
					this.Onorderaddress1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderaddress2", DbType="NVarChar(MAX)")]
		public string orderaddress2
		{
			get
			{
				return this._orderaddress2;
			}
			set
			{
				if ((this._orderaddress2 != value))
				{
					this.Onorderaddress2Changing(value);
					this.SendPropertyChanging();
					this._orderaddress2 = value;
					this.SendPropertyChanged("orderaddress2");
					this.Onorderaddress2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ordertown", DbType="NVarChar(MAX)")]
		public string ordertown
		{
			get
			{
				return this._ordertown;
			}
			set
			{
				if ((this._ordertown != value))
				{
					this.OnordertownChanging(value);
					this.SendPropertyChanging();
					this._ordertown = value;
					this.SendPropertyChanged("ordertown");
					this.OnordertownChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderpostcode", DbType="NVarChar(50)")]
		public string orderpostcode
		{
			get
			{
				return this._orderpostcode;
			}
			set
			{
				if ((this._orderpostcode != value))
				{
					this.OnorderpostcodeChanging(value);
					this.SendPropertyChanging();
					this._orderpostcode = value;
					this.SendPropertyChanged("orderpostcode");
					this.OnorderpostcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_countyid", DbType="Int")]
		public System.Nullable<int> countyid
		{
			get
			{
				return this._countyid;
			}
			set
			{
				if ((this._countyid != value))
				{
					if (this._county.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncountyidChanging(value);
					this.SendPropertyChanging();
					this._countyid = value;
					this.SendPropertyChanged("countyid");
					this.OncountyidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderpaid", DbType="Bit NOT NULL")]
		public bool orderpaid
		{
			get
			{
				return this._orderpaid;
			}
			set
			{
				if ((this._orderpaid != value))
				{
					this.OnorderpaidChanging(value);
					this.SendPropertyChanging();
					this._orderpaid = value;
					this.SendPropertyChanged("orderpaid");
					this.OnorderpaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ordersent", DbType="Bit NOT NULL")]
		public bool ordersent
		{
			get
			{
				return this._ordersent;
			}
			set
			{
				if ((this._ordersent != value))
				{
					this.OnordersentChanging(value);
					this.SendPropertyChanging();
					this._ordersent = value;
					this.SendPropertyChanged("ordersent");
					this.OnordersentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_bookorder", Storage="_bookorders", ThisKey="orderid", OtherKey="orderid")]
		public EntitySet<bookorder> bookorders
		{
			get
			{
				return this._bookorders;
			}
			set
			{
				this._bookorders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="county_order", Storage="_county", ThisKey="countyid", OtherKey="countyid", IsForeignKey=true)]
		public county county
		{
			get
			{
				return this._county.Entity;
			}
			set
			{
				county previousValue = this._county.Entity;
				if (((previousValue != value) 
							|| (this._county.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._county.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._county.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._countyid = value.countyid;
					}
					else
					{
						this._countyid = default(Nullable<int>);
					}
					this.SendPropertyChanged("county");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_bookorders(bookorder entity)
		{
			this.SendPropertyChanging();
			entity.order = this;
		}
		
		private void detach_bookorders(bookorder entity)
		{
			this.SendPropertyChanging();
			entity.order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bookorder")]
	public partial class bookorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderbookid;
		
		private System.Nullable<int> _orderid;
		
		private System.Nullable<int> _bookid;
		
		private System.Nullable<int> _orderbookquantity;
		
		private System.Nullable<decimal> _ordervalue;
		
		private EntityRef<order> _order;
		
		private EntityRef<Book> _Book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderbookidChanging(int value);
    partial void OnorderbookidChanged();
    partial void OnorderidChanging(System.Nullable<int> value);
    partial void OnorderidChanged();
    partial void OnbookidChanging(System.Nullable<int> value);
    partial void OnbookidChanged();
    partial void OnorderbookquantityChanging(System.Nullable<int> value);
    partial void OnorderbookquantityChanged();
    partial void OnordervalueChanging(System.Nullable<decimal> value);
    partial void OnordervalueChanged();
    #endregion
		
		public bookorder()
		{
			this._order = default(EntityRef<order>);
			this._Book = default(EntityRef<Book>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderbookid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int orderbookid
		{
			get
			{
				return this._orderbookid;
			}
			set
			{
				if ((this._orderbookid != value))
				{
					this.OnorderbookidChanging(value);
					this.SendPropertyChanging();
					this._orderbookid = value;
					this.SendPropertyChanged("orderbookid");
					this.OnorderbookidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderid", DbType="Int")]
		public System.Nullable<int> orderid
		{
			get
			{
				return this._orderid;
			}
			set
			{
				if ((this._orderid != value))
				{
					if (this._order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderidChanging(value);
					this.SendPropertyChanging();
					this._orderid = value;
					this.SendPropertyChanged("orderid");
					this.OnorderidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookid", DbType="Int")]
		public System.Nullable<int> bookid
		{
			get
			{
				return this._bookid;
			}
			set
			{
				if ((this._bookid != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbookidChanging(value);
					this.SendPropertyChanging();
					this._bookid = value;
					this.SendPropertyChanged("bookid");
					this.OnbookidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderbookquantity", DbType="Int")]
		public System.Nullable<int> orderbookquantity
		{
			get
			{
				return this._orderbookquantity;
			}
			set
			{
				if ((this._orderbookquantity != value))
				{
					this.OnorderbookquantityChanging(value);
					this.SendPropertyChanging();
					this._orderbookquantity = value;
					this.SendPropertyChanged("orderbookquantity");
					this.OnorderbookquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ordervalue", DbType="Money")]
		public System.Nullable<decimal> ordervalue
		{
			get
			{
				return this._ordervalue;
			}
			set
			{
				if ((this._ordervalue != value))
				{
					this.OnordervalueChanging(value);
					this.SendPropertyChanging();
					this._ordervalue = value;
					this.SendPropertyChanged("ordervalue");
					this.OnordervalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_bookorder", Storage="_order", ThisKey="orderid", OtherKey="orderid", IsForeignKey=true)]
		public order order
		{
			get
			{
				return this._order.Entity;
			}
			set
			{
				order previousValue = this._order.Entity;
				if (((previousValue != value) 
							|| (this._order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._order.Entity = null;
						previousValue.bookorders.Remove(this);
					}
					this._order.Entity = value;
					if ((value != null))
					{
						value.bookorders.Add(this);
						this._orderid = value.orderid;
					}
					else
					{
						this._orderid = default(Nullable<int>);
					}
					this.SendPropertyChanged("order");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_bookorder", Storage="_Book", ThisKey="bookid", OtherKey="bookid", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.bookorders.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.bookorders.Add(this);
						this._bookid = value.bookid;
					}
					else
					{
						this._bookid = default(Nullable<int>);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _bookid;
		
		private string _bookTitle;
		
		private System.Nullable<decimal> _bookPrice;
		
		private string _bookImageURL;
		
		private EntitySet<bookorder> _bookorders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbookidChanging(int value);
    partial void OnbookidChanged();
    partial void OnbookTitleChanging(string value);
    partial void OnbookTitleChanged();
    partial void OnbookPriceChanging(System.Nullable<decimal> value);
    partial void OnbookPriceChanged();
    partial void OnbookImageURLChanging(string value);
    partial void OnbookImageURLChanged();
    #endregion
		
		public Book()
		{
			this._bookorders = new EntitySet<bookorder>(new Action<bookorder>(this.attach_bookorders), new Action<bookorder>(this.detach_bookorders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int bookid
		{
			get
			{
				return this._bookid;
			}
			set
			{
				if ((this._bookid != value))
				{
					this.OnbookidChanging(value);
					this.SendPropertyChanging();
					this._bookid = value;
					this.SendPropertyChanged("bookid");
					this.OnbookidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookTitle", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string bookTitle
		{
			get
			{
				return this._bookTitle;
			}
			set
			{
				if ((this._bookTitle != value))
				{
					this.OnbookTitleChanging(value);
					this.SendPropertyChanging();
					this._bookTitle = value;
					this.SendPropertyChanged("bookTitle");
					this.OnbookTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookPrice", DbType="Money")]
		public System.Nullable<decimal> bookPrice
		{
			get
			{
				return this._bookPrice;
			}
			set
			{
				if ((this._bookPrice != value))
				{
					this.OnbookPriceChanging(value);
					this.SendPropertyChanging();
					this._bookPrice = value;
					this.SendPropertyChanged("bookPrice");
					this.OnbookPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookImageURL", DbType="NVarChar(MAX)")]
		public string bookImageURL
		{
			get
			{
				return this._bookImageURL;
			}
			set
			{
				if ((this._bookImageURL != value))
				{
					this.OnbookImageURLChanging(value);
					this.SendPropertyChanging();
					this._bookImageURL = value;
					this.SendPropertyChanged("bookImageURL");
					this.OnbookImageURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_bookorder", Storage="_bookorders", ThisKey="bookid", OtherKey="bookid")]
		public EntitySet<bookorder> bookorders
		{
			get
			{
				return this._bookorders;
			}
			set
			{
				this._bookorders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_bookorders(bookorder entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_bookorders(bookorder entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.county")]
	public partial class county : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _countyid;
		
		private string _county1;
		
		private EntitySet<order> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncountyidChanging(int value);
    partial void OncountyidChanged();
    partial void Oncounty1Changing(string value);
    partial void Oncounty1Changed();
    #endregion
		
		public county()
		{
			this._orders = new EntitySet<order>(new Action<order>(this.attach_orders), new Action<order>(this.detach_orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_countyid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int countyid
		{
			get
			{
				return this._countyid;
			}
			set
			{
				if ((this._countyid != value))
				{
					this.OncountyidChanging(value);
					this.SendPropertyChanging();
					this._countyid = value;
					this.SendPropertyChanged("countyid");
					this.OncountyidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="county", Storage="_county1", DbType="VarChar(MAX)")]
		public string county1
		{
			get
			{
				return this._county1;
			}
			set
			{
				if ((this._county1 != value))
				{
					this.Oncounty1Changing(value);
					this.SendPropertyChanging();
					this._county1 = value;
					this.SendPropertyChanged("county1");
					this.Oncounty1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="county_order", Storage="_orders", ThisKey="countyid", OtherKey="countyid")]
		public EntitySet<order> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.county = this;
		}
		
		private void detach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.county = null;
		}
	}
}
#pragma warning restore 1591
