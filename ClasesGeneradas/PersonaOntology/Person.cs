using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Gnoss.ApiWrapper;
using Gnoss.ApiWrapper.Model;
using GnossBase;
using Es.Riam.Gnoss.Web.MVC.Models;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;
using Movie = PeliculaOntology.Movie;

namespace PersonaOntology
{
	[ExcludeFromCodeCoverage]
	public class Person : GnossOCBase
	{
		public Person() : base() { } 

		public Person(SemanticResourceModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			GNOSSID = pSemCmsModel.RootEntities[0].Entity.Uri;
			Schema_directoresComunDirector = new List<Person>();
			SemanticPropertyModel propSchema_directoresComunDirector = pSemCmsModel.GetPropertyByPath("http://schema.org/directoresComunDirector");
			if(propSchema_directoresComunDirector != null && propSchema_directoresComunDirector.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_directoresComunDirector.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_directoresComunDirector = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_directoresComunDirector.Add(schema_directoresComunDirector);
					}
				}
			}
			Schema_directoresComunActor = new List<Person>();
			SemanticPropertyModel propSchema_directoresComunActor = pSemCmsModel.GetPropertyByPath("http://schema.org/directoresComunActor");
			if(propSchema_directoresComunActor != null && propSchema_directoresComunActor.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_directoresComunActor.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_directoresComunActor = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_directoresComunActor.Add(schema_directoresComunActor);
					}
				}
			}
			Schema_iDirector = new List<Movie>();
			SemanticPropertyModel propSchema_iDirector = pSemCmsModel.GetPropertyByPath("http://schema.org/iDirector");
			if(propSchema_iDirector != null && propSchema_iDirector.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_iDirector.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Movie schema_iDirector = new Movie(propValue.RelatedEntity,idiomaUsuario);
						Schema_iDirector.Add(schema_iDirector);
					}
				}
			}
			Schema_actoresComunDirector = new List<Person>();
			SemanticPropertyModel propSchema_actoresComunDirector = pSemCmsModel.GetPropertyByPath("http://schema.org/actoresComunDirector");
			if(propSchema_actoresComunDirector != null && propSchema_actoresComunDirector.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_actoresComunDirector.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_actoresComunDirector = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_actoresComunDirector.Add(schema_actoresComunDirector);
					}
				}
			}
			Schema_actoresComunActor = new List<Person>();
			SemanticPropertyModel propSchema_actoresComunActor = pSemCmsModel.GetPropertyByPath("http://schema.org/actoresComunActor");
			if(propSchema_actoresComunActor != null && propSchema_actoresComunActor.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_actoresComunActor.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_actoresComunActor = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_actoresComunActor.Add(schema_actoresComunActor);
					}
				}
			}
			Schema_iActors = new List<Movie>();
			SemanticPropertyModel propSchema_iActors = pSemCmsModel.GetPropertyByPath("http://schema.org/iActors");
			if(propSchema_iActors != null && propSchema_iActors.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_iActors.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Movie schema_iActors = new Movie(propValue.RelatedEntity,idiomaUsuario);
						Schema_iActors.Add(schema_iActors);
					}
				}
			}
			this.Schema_image = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/image"));
			this.Schema_name = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/name"));
		}

		public Person(SemanticEntityModel pSemCmsModel, LanguageEnum idiomaUsuario) : base()
		{
			mGNOSSID = pSemCmsModel.Entity.Uri;
			mURL = pSemCmsModel.Properties.FirstOrDefault(p => p.PropertyValues.Any(prop => prop.DownloadUrl != null))?.FirstPropertyValue.DownloadUrl;
			Schema_directoresComunDirector = new List<Person>();
			SemanticPropertyModel propSchema_directoresComunDirector = pSemCmsModel.GetPropertyByPath("http://schema.org/directoresComunDirector");
			if(propSchema_directoresComunDirector != null && propSchema_directoresComunDirector.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_directoresComunDirector.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_directoresComunDirector = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_directoresComunDirector.Add(schema_directoresComunDirector);
					}
				}
			}
			Schema_directoresComunActor = new List<Person>();
			SemanticPropertyModel propSchema_directoresComunActor = pSemCmsModel.GetPropertyByPath("http://schema.org/directoresComunActor");
			if(propSchema_directoresComunActor != null && propSchema_directoresComunActor.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_directoresComunActor.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_directoresComunActor = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_directoresComunActor.Add(schema_directoresComunActor);
					}
				}
			}
			Schema_iDirector = new List<Movie>();
			SemanticPropertyModel propSchema_iDirector = pSemCmsModel.GetPropertyByPath("http://schema.org/iDirector");
			if(propSchema_iDirector != null && propSchema_iDirector.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_iDirector.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Movie schema_iDirector = new Movie(propValue.RelatedEntity,idiomaUsuario);
						Schema_iDirector.Add(schema_iDirector);
					}
				}
			}
			Schema_actoresComunDirector = new List<Person>();
			SemanticPropertyModel propSchema_actoresComunDirector = pSemCmsModel.GetPropertyByPath("http://schema.org/actoresComunDirector");
			if(propSchema_actoresComunDirector != null && propSchema_actoresComunDirector.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_actoresComunDirector.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_actoresComunDirector = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_actoresComunDirector.Add(schema_actoresComunDirector);
					}
				}
			}
			Schema_actoresComunActor = new List<Person>();
			SemanticPropertyModel propSchema_actoresComunActor = pSemCmsModel.GetPropertyByPath("http://schema.org/actoresComunActor");
			if(propSchema_actoresComunActor != null && propSchema_actoresComunActor.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_actoresComunActor.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Person schema_actoresComunActor = new Person(propValue.RelatedEntity,idiomaUsuario);
						Schema_actoresComunActor.Add(schema_actoresComunActor);
					}
				}
			}
			Schema_iActors = new List<Movie>();
			SemanticPropertyModel propSchema_iActors = pSemCmsModel.GetPropertyByPath("http://schema.org/iActors");
			if(propSchema_iActors != null && propSchema_iActors.PropertyValues.Count > 0)
			{
				foreach (SemanticPropertyModel.PropertyValue propValue in propSchema_iActors.PropertyValues)
				{
					if(propValue.RelatedEntity!=null){
						Movie schema_iActors = new Movie(propValue.RelatedEntity,idiomaUsuario);
						Schema_iActors.Add(schema_iActors);
					}
				}
			}
			this.Schema_image = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/image"));
			this.Schema_name = GetPropertyValueSemCms(pSemCmsModel.GetPropertyByPath("http://schema.org/name"));
		}

		public virtual string RdfType { get { return "http://schema.org/Person"; } }
		public virtual string RdfsLabel { get { return "http://schema.org/Person"; } }
		[LABEL(LanguageEnum.es,"http://schema.org/directoresComunDirector")]
		[RDFProperty("http://schema.org/directoresComunDirector")]
		public  List<Person> Schema_directoresComunDirector { get; set;}
		public List<string> IdsSchema_directoresComunDirector { get; set;}

		[LABEL(LanguageEnum.es,"")]
		[RDFProperty("http://schema.org/directoresComunActor")]
		public  List<Person> Schema_directoresComunActor { get; set;}
		public List<string> IdsSchema_directoresComunActor { get; set;}

		[LABEL(LanguageEnum.es,"http://schema.org/iDirector")]
		[RDFProperty("http://schema.org/iDirector")]
		public  List<Movie> Schema_iDirector { get; set;}
		public List<string> IdsSchema_iDirector { get; set;}

		[LABEL(LanguageEnum.es,"http://schema.org/actoresComunDirector")]
		[RDFProperty("http://schema.org/actoresComunDirector")]
		public  List<Person> Schema_actoresComunDirector { get; set;}
		public List<string> IdsSchema_actoresComunDirector { get; set;}

		[LABEL(LanguageEnum.es,"")]
		[RDFProperty("http://schema.org/actoresComunActor")]
		public  List<Person> Schema_actoresComunActor { get; set;}
		public List<string> IdsSchema_actoresComunActor { get; set;}

		[LABEL(LanguageEnum.es,"")]
		[RDFProperty("http://schema.org/iActors")]
		public  List<Movie> Schema_iActors { get; set;}
		public List<string> IdsSchema_iActors { get; set;}

		[LABEL(LanguageEnum.es,"Imagen:")]
		[RDFProperty("http://schema.org/image")]
		public  string Schema_image { get; set;}

		[LABEL(LanguageEnum.es,"Nombre:")]
		[RDFProperty("http://schema.org/name")]
		public  string Schema_name { get; set;}


		internal override void GetProperties()
		{
			base.GetProperties();
			propList.Add(new ListStringOntologyProperty("schema:directoresComunDirector", this.IdsSchema_directoresComunDirector));
			propList.Add(new ListStringOntologyProperty("schema:directoresComunActor", this.IdsSchema_directoresComunActor));
			propList.Add(new ListStringOntologyProperty("schema:iDirector", this.IdsSchema_iDirector));
			propList.Add(new ListStringOntologyProperty("schema:actoresComunDirector", this.IdsSchema_actoresComunDirector));
			propList.Add(new ListStringOntologyProperty("schema:actoresComunActor", this.IdsSchema_actoresComunActor));
			propList.Add(new ListStringOntologyProperty("schema:iActors", this.IdsSchema_iActors));
			propList.Add(new StringOntologyProperty("schema:image", this.Schema_image));
			propList.Add(new StringOntologyProperty("schema:name", this.Schema_name));
		}

		internal override void GetEntities()
		{
			base.GetEntities();
		} 
		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI)
		{
			return ToGnossApiResource(resourceAPI, new List<string>());
		}

		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI, List<string> listaDeCategorias)
		{
			return ToGnossApiResource(resourceAPI, listaDeCategorias, Guid.Empty, Guid.Empty);
		}

		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI, List<Guid> listaDeCategorias)
		{
			return ToGnossApiResource(resourceAPI, null, Guid.Empty, Guid.Empty, listaDeCategorias);
		}

		public virtual ComplexOntologyResource ToGnossApiResource(ResourceApi resourceAPI, List<string> listaDeCategorias, Guid idrecurso, Guid idarticulo, List<Guid> listaIdDeCategorias = null)
		{
			ComplexOntologyResource resource = new ComplexOntologyResource();
			Ontology ontology = null;
			GetProperties();
			if(idrecurso.Equals(Guid.Empty) && idarticulo.Equals(Guid.Empty))
			{
				ontology = new Ontology(resourceAPI.GraphsUrl, resourceAPI.OntologyUrl, RdfType, RdfsLabel, prefList, propList, entList);
			}
			else{
				ontology = new Ontology(resourceAPI.GraphsUrl, resourceAPI.OntologyUrl, RdfType, RdfsLabel, prefList, propList, entList,idrecurso,idarticulo);
			}
			resource.Id = GNOSSID;
			resource.Ontology = ontology;
			resource.TextCategories = listaDeCategorias;
			resource.CategoriesIds = listaIdDeCategorias;
			AddResourceTitle(resource);
			AddResourceDescription(resource);
			AddImages(resource);
			AddFiles(resource);
			return resource;
		}

		public override List<string> ToOntologyGnossTriples(ResourceApi resourceAPI)
		{
			List<string> list = new List<string>();
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"<http://schema.org/Person>", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://www.w3.org/2000/01/rdf-schema#label", $"\"http://schema.org/Person\"", list, " . ");
			AgregarTripleALista($"{resourceAPI.GraphsUrl}{ResourceID}", "http://gnoss/hasEntidad", $"<{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}>", list, " . ");
				if(this.IdsSchema_directoresComunDirector != null)
				{
					foreach(var item2 in this.IdsSchema_directoresComunDirector)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://schema.org/directoresComunDirector", $"<{item2}>", list, " . ");
					}
				}
				if(this.IdsSchema_directoresComunActor != null)
				{
					foreach(var item2 in this.IdsSchema_directoresComunActor)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://schema.org/directoresComunActor", $"<{item2}>", list, " . ");
					}
				}
				if(this.IdsSchema_iDirector != null)
				{
					foreach(var item2 in this.IdsSchema_iDirector)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://schema.org/iDirector", $"<{item2}>", list, " . ");
					}
				}
				if(this.IdsSchema_actoresComunDirector != null)
				{
					foreach(var item2 in this.IdsSchema_actoresComunDirector)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://schema.org/actoresComunDirector", $"<{item2}>", list, " . ");
					}
				}
				if(this.IdsSchema_actoresComunActor != null)
				{
					foreach(var item2 in this.IdsSchema_actoresComunActor)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://schema.org/actoresComunActor", $"<{item2}>", list, " . ");
					}
				}
				if(this.IdsSchema_iActors != null)
				{
					foreach(var item2 in this.IdsSchema_iActors)
					{
						AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}", "http://schema.org/iActors", $"<{item2}>", list, " . ");
					}
				}
				if(this.Schema_image != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}",  "http://schema.org/image", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_image)}\"", list, " . ");
				}
				if(this.Schema_name != null)
				{
					AgregarTripleALista($"{resourceAPI.GraphsUrl}items/Person_{ResourceID}_{ArticleID}",  "http://schema.org/name", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
				}
			return list;
		}

		public override List<string> ToSearchGraphTriples(ResourceApi resourceAPI)
		{
			List<string> list = new List<string>();
			List<string> listaSearch = new List<string>();
			AgregarTags(list);
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://www.w3.org/1999/02/22-rdf-syntax-ns#type", $"\"persona\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/type", $"\"http://schema.org/Person\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechapublicacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hastipodoc", "\"5\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasfechamodificacion", $"{DateTime.Now.ToString("yyyyMMddHHmmss")}", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnumeroVisitas", "0", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasprivacidadCom", "\"publico\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://xmlns.com/foaf/0.1/firstName", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
			AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/hasnombrecompleto", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
			string search = string.Empty;
				if(this.IdsSchema_directoresComunDirector != null)
				{
					foreach(var item2 in this.IdsSchema_directoresComunDirector)
					{
					Regex regex = new Regex(@"\/items\/.+_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}");
					string itemRegex = item2;
					if (regex.IsMatch(itemRegex))
					{
						itemRegex = $"http://gnoss/{resourceAPI.GetShortGuid(itemRegex).ToString().ToUpper()}";
					}
					else
					{
						itemRegex = itemRegex.ToLower();
					}
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/directoresComunDirector", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.IdsSchema_directoresComunActor != null)
				{
					foreach(var item2 in this.IdsSchema_directoresComunActor)
					{
					Regex regex = new Regex(@"\/items\/.+_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}");
					string itemRegex = item2;
					if (regex.IsMatch(itemRegex))
					{
						itemRegex = $"http://gnoss/{resourceAPI.GetShortGuid(itemRegex).ToString().ToUpper()}";
					}
					else
					{
						itemRegex = itemRegex.ToLower();
					}
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/directoresComunActor", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.IdsSchema_iDirector != null)
				{
					foreach(var item2 in this.IdsSchema_iDirector)
					{
					Regex regex = new Regex(@"\/items\/.+_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}");
					string itemRegex = item2;
					if (regex.IsMatch(itemRegex))
					{
						itemRegex = $"http://gnoss/{resourceAPI.GetShortGuid(itemRegex).ToString().ToUpper()}";
					}
					else
					{
						itemRegex = itemRegex.ToLower();
					}
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/iDirector", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.IdsSchema_actoresComunDirector != null)
				{
					foreach(var item2 in this.IdsSchema_actoresComunDirector)
					{
					Regex regex = new Regex(@"\/items\/.+_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}");
					string itemRegex = item2;
					if (regex.IsMatch(itemRegex))
					{
						itemRegex = $"http://gnoss/{resourceAPI.GetShortGuid(itemRegex).ToString().ToUpper()}";
					}
					else
					{
						itemRegex = itemRegex.ToLower();
					}
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/actoresComunDirector", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.IdsSchema_actoresComunActor != null)
				{
					foreach(var item2 in this.IdsSchema_actoresComunActor)
					{
					Regex regex = new Regex(@"\/items\/.+_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}");
					string itemRegex = item2;
					if (regex.IsMatch(itemRegex))
					{
						itemRegex = $"http://gnoss/{resourceAPI.GetShortGuid(itemRegex).ToString().ToUpper()}";
					}
					else
					{
						itemRegex = itemRegex.ToLower();
					}
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/actoresComunActor", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.IdsSchema_iActors != null)
				{
					foreach(var item2 in this.IdsSchema_iActors)
					{
					Regex regex = new Regex(@"\/items\/.+_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}_[0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}");
					string itemRegex = item2;
					if (regex.IsMatch(itemRegex))
					{
						itemRegex = $"http://gnoss/{resourceAPI.GetShortGuid(itemRegex).ToString().ToUpper()}";
					}
					else
					{
						itemRegex = itemRegex.ToLower();
					}
						AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://schema.org/iActors", $"<{itemRegex}>", list, " . ");
					}
				}
				if(this.Schema_image != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}",  "http://schema.org/image", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_image)}\"", list, " . ");
				}
				if(this.Schema_name != null)
				{
					AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}",  "http://schema.org/name", $"\"{GenerarTextoSinSaltoDeLinea(this.Schema_name)}\"", list, " . ");
				}
			if (listaSearch != null && listaSearch.Count > 0)
			{
				foreach(string valorSearch in listaSearch)
				{
					search += $"{valorSearch} ";
				}
			}
			if(!string.IsNullOrEmpty(search))
			{
				AgregarTripleALista($"http://gnoss/{ResourceID.ToString().ToUpper()}", "http://gnoss/search", $"\"{GenerarTextoSinSaltoDeLinea(search.ToLower())}\"", list, " . ");
			}
			return list;
		}

		public override KeyValuePair<Guid, string> ToAcidData(ResourceApi resourceAPI)
		{

			//Insert en la tabla Documento
			string tags = "";
			foreach(string tag in tagList)
			{
				tags += $"{tag}, ";
			}
			if (!string.IsNullOrEmpty(tags))
			{
				tags = tags.Substring(0, tags.LastIndexOf(','));
			}
			string titulo = $"{this.Schema_name.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\"", "\"\"").Replace("'", "#COMILLA#").Replace("|", "#PIPE#")}";
			string descripcion = $"{this.Schema_name.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace("\"", "\"\"").Replace("'", "#COMILLA#").Replace("|", "#PIPE#")}";
			string tablaDoc = $"'{titulo}', '{descripcion}', '{resourceAPI.GraphsUrl}', '{tags}'";
			KeyValuePair<Guid, string> valor = new KeyValuePair<Guid, string>(ResourceID, tablaDoc);

			return valor;
		}

		public override string GetURI(ResourceApi resourceAPI)
		{
			return $"{resourceAPI.GraphsUrl}items/PersonaOntology_{ResourceID}_{ArticleID}";
		}


		internal void AddResourceTitle(ComplexOntologyResource resource)
		{
			resource.Title = this.Schema_name;
		}

		internal void AddResourceDescription(ComplexOntologyResource resource)
		{
			resource.Description = this.Schema_name;
		}




	}
}
