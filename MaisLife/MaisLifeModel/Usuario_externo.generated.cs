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
	public partial class Usuario_externo : System.Runtime.Serialization.ISerializable
	{
		private string _nome;
		public virtual string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				this._nome = value;
			}
		}
		
		private string _documento;
		public virtual string Documento
		{
			get
			{
				return this._documento;
			}
			set
			{
				this._documento = value;
			}
		}
		
		private string _telefone;
		public virtual string Telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				this._telefone = value;
			}
		}
		
		private int _endereco;
		public virtual int Endereco
		{
			get
			{
				return this._endereco;
			}
			set
			{
				this._endereco = value;
			}
		}
		
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
		
		private Endereco _endereco1;
		public virtual Endereco Endereco1
		{
			get
			{
				return this._endereco1;
			}
			set
			{
				this._endereco1 = value;
			}
		}
		
		private IList<Pedido> _pedidos = new List<Pedido>();
		public virtual IList<Pedido> Pedidos
		{
			get
			{
				return this._pedidos;
			}
            set
            {
                this._pedidos = value;
            }

		}
		
		#region ISerializable Implementation
		
		public Usuario_externo()
		{
		}
		
		protected Usuario_externo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.Nome = info.GetString("Nome");
			this.Documento = info.GetString("Documento");
			this.Telefone = info.GetString("Telefone");
			this.Endereco = info.GetInt32("Endereco");
			this.Id = info.GetInt32("Id");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("Nome", this.Nome, typeof(string));
			info.AddValue("Documento", this.Documento, typeof(string));
			info.AddValue("Telefone", this.Telefone, typeof(string));
			info.AddValue("Endereco", this.Endereco, typeof(int));
			info.AddValue("Id", this.Id, typeof(int));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
