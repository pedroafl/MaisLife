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
	public partial class Devolucao : System.Runtime.Serialization.ISerializable
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
		
		private string _tipo;
		public virtual string Tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				this._tipo = value;
			}
		}
		
		private int _cliente;
		public virtual int Cliente
		{
			get
			{
				return this._cliente;
			}
			set
			{
				this._cliente = value;
			}
		}
		
		private string _motivo;
		public virtual string Motivo
		{
			get
			{
				return this._motivo;
			}
			set
			{
				this._motivo = value;
			}
		}
		
		private IList<Devolucao_produto> _devolucao_produtos = new List<Devolucao_produto>();
		public virtual IList<Devolucao_produto> Devolucao_produtos
		{
			get
			{
				return this._devolucao_produtos;
			}
            set
            {
                this._devolucao_produtos = value;
            }
		}
		
		#region ISerializable Implementation
		
		public Devolucao()
		{
		}
		
		protected Devolucao(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.Id = info.GetInt32("Id");
			this.Data = (DateTime)info.GetValue("Data", typeof(DateTime));
			this.Tipo = info.GetString("Tipo");
			this.Cliente = info.GetInt32("Cliente");
			this.Motivo = info.GetString("Motivo");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("Id", this.Id, typeof(int));
			info.AddValue("Data", this.Data, typeof(DateTime));
			info.AddValue("Tipo", this.Tipo, typeof(string));
			info.AddValue("Cliente", this.Cliente, typeof(int));
			info.AddValue("Motivo", this.Motivo, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
