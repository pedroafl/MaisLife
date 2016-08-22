#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using MaisLifeModel;

namespace MaisLifeModel	
{
	[System.Serializable()]
	public partial class Entrada : System.Runtime.Serialization.ISerializable
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private int _numero;
		public virtual int Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				this._numero = value;
			}
		}
		
		private DateTime _data;
		public virtual DateTime Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		
		private int _fornecedor;
		public virtual int Fornecedor
		{
			get
			{
				return this._fornecedor;
			}
			set
			{
				this._fornecedor = value;
			}
		}
		
		private Fornecedor _fornecedor1;
		public virtual Fornecedor Fornecedor1
		{
			get
			{
				return this._fornecedor1;
			}
			set
			{
				this._fornecedor1 = value;
			}
		}
		
		private IList<Entrada_estoque> _entrada_estoques = new List<Entrada_estoque>();
		public virtual IList<Entrada_estoque> Entrada_estoques
		{
			get
			{
				return this._entrada_estoques;
			}
            set
            {
                this._entrada_estoques = value;
            }
		}
		
		#region ISerializable Implementation
		
		public Entrada()
		{
		}
		
		protected Entrada(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.Id = info.GetInt32("Id");
			this.Numero = info.GetInt32("Numero");
			this.Data = (DateTime)info.GetValue("Data", typeof(DateTime));
			this.Fornecedor = info.GetInt32("Fornecedor");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("Id", this.Id, typeof(int));
			info.AddValue("Numero", this.Numero, typeof(int));
			info.AddValue("Data", this.Data, typeof(DateTime));
			info.AddValue("Fornecedor", this.Fornecedor, typeof(int));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591