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
	public partial class Carrinho : System.Runtime.Serialization.ISerializable
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
		
		private int? _usuario;
		public virtual int? Usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				this._usuario = value;
			}
		}
		
		private string _status;
		public virtual string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		
		private Usuario _usuario1;
		public virtual Usuario Usuario1
		{
			get
			{
				return this._usuario1;
			}
			set
			{
				this._usuario1 = value;
			}
		}
		
		private IList<Pedido> _pedidos = new List<Pedido>();
		public virtual IList<Pedido> Pedidos
		{
			get
			{
				return this._pedidos;
			}
            set {
                this._pedidos = value;    
            }
		}
		
		private IList<Carrinho_produto> _carrinho_produtos = new List<Carrinho_produto>();
		public virtual IList<Carrinho_produto> Carrinho_produtos
		{
			get
			{
				return this._carrinho_produtos;
			}
            set
            {
                this._carrinho_produtos = value;
            }
		}

        public Carrinho_produto checkProduct(Produto produto)
        {
            foreach (var rel in Carrinho_produtos)
            {
                if (rel.Produto == produto.Id)
                    return rel;
            }

            return null;
        }

        public decimal Total(decimal sum)
        {
            decimal? total = 0;
            foreach (var rel in Carrinho_produtos)
            {
                total += rel.Quantidade * rel.Produto1.Preco;
            }

            return (decimal)total + sum;

        }


        public int TotalItens()
        {
            int amount = 0;
            foreach (var rel in Carrinho_produtos)
            {
                amount += (int)rel.Quantidade;
            }

            return amount;
        }
		
		#region ISerializable Implementation
		
		public Carrinho()
		{
		}
		
		protected Carrinho(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.Id = info.GetInt32("Id");
			this.Usuario = (int?)info.GetValue("Usuario", typeof(int?));
			this.Status = info.GetString("Status");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("Id", this.Id, typeof(int));
			info.AddValue("Usuario", this.Usuario, typeof(int?));
			info.AddValue("Status", this.Status, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
