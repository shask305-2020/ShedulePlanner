﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShedulePlanner.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ExRaspisDBEntities : DbContext
    {
        private static ExRaspisDBEntities context;
        public ExRaspisDBEntities()
            : base("name=ExRaspisDBEntities")
        {
        }

        public static ExRaspisDBEntities GetContext()
        {
            if (context == null) { context = new ExRaspisDBEntities(); }
            return context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NED> NED { get; set; }
        public virtual DbSet<PLAN> PLAN { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SPGRUP> SPGRUP { get; set; }
        public virtual DbSet<SPNAGR> SPNAGR { get; set; }
        public virtual DbSet<SPPRED> SPPRED { get; set; }
        public virtual DbSet<SPPREP> SPPREP { get; set; }
        public virtual DbSet<UROKI> UROKI { get; set; }
    
        public virtual ObjectResult<Nullable<int>> CountUroki(Nullable<int> iDP, Nullable<int> iDG, Nullable<int> iDD, Nullable<System.DateTime> dAT)
        {
            var iDPParameter = iDP.HasValue ?
                new ObjectParameter("IDP", iDP) :
                new ObjectParameter("IDP", typeof(int));
    
            var iDGParameter = iDG.HasValue ?
                new ObjectParameter("IDG", iDG) :
                new ObjectParameter("IDG", typeof(int));
    
            var iDDParameter = iDD.HasValue ?
                new ObjectParameter("IDD", iDD) :
                new ObjectParameter("IDD", typeof(int));
    
            var dATParameter = dAT.HasValue ?
                new ObjectParameter("DAT", dAT) :
                new ObjectParameter("DAT", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CountUroki", iDPParameter, iDGParameter, iDDParameter, dATParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CountUroki_Otchet_interval(Nullable<int> iDP, Nullable<int> iDG, Nullable<int> iDD, Nullable<System.DateTime> dAT_N, Nullable<System.DateTime> dAT_K)
        {
            var iDPParameter = iDP.HasValue ?
                new ObjectParameter("IDP", iDP) :
                new ObjectParameter("IDP", typeof(int));
    
            var iDGParameter = iDG.HasValue ?
                new ObjectParameter("IDG", iDG) :
                new ObjectParameter("IDG", typeof(int));
    
            var iDDParameter = iDD.HasValue ?
                new ObjectParameter("IDD", iDD) :
                new ObjectParameter("IDD", typeof(int));
    
            var dAT_NParameter = dAT_N.HasValue ?
                new ObjectParameter("DAT_N", dAT_N) :
                new ObjectParameter("DAT_N", typeof(System.DateTime));
    
            var dAT_KParameter = dAT_K.HasValue ?
                new ObjectParameter("DAT_K", dAT_K) :
                new ObjectParameter("DAT_K", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CountUroki_Otchet_interval", iDPParameter, iDGParameter, iDDParameter, dAT_NParameter, dAT_KParameter);
        }
    
        public virtual int MergePlan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MergePlan");
        }
    
        public virtual ObjectResult<pr_LoadGroup_Result> pr_LoadGroup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_LoadGroup_Result>("pr_LoadGroup");
        }
    
        public virtual ObjectResult<pr_LoadNagrGroup_Result> pr_LoadNagrGroup(Nullable<int> iDG)
        {
            var iDGParameter = iDG.HasValue ?
                new ObjectParameter("IDG", iDG) :
                new ObjectParameter("IDG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_LoadNagrGroup_Result>("pr_LoadNagrGroup", iDGParameter);
        }
    
        public virtual ObjectResult<pr_LoadNagrPrepod_Result> pr_LoadNagrPrepod(Nullable<int> iDP)
        {
            var iDPParameter = iDP.HasValue ?
                new ObjectParameter("IDP", iDP) :
                new ObjectParameter("IDP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_LoadNagrPrepod_Result>("pr_LoadNagrPrepod", iDPParameter);
        }
    
        public virtual ObjectResult<pr_LoadPlan_Result> pr_LoadPlan(Nullable<int> iDP, Nullable<int> iDG, Nullable<int> iDD)
        {
            var iDPParameter = iDP.HasValue ?
                new ObjectParameter("IDP", iDP) :
                new ObjectParameter("IDP", typeof(int));
    
            var iDGParameter = iDG.HasValue ?
                new ObjectParameter("IDG", iDG) :
                new ObjectParameter("IDG", typeof(int));
    
            var iDDParameter = iDD.HasValue ?
                new ObjectParameter("IDD", iDD) :
                new ObjectParameter("IDD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_LoadPlan_Result>("pr_LoadPlan", iDPParameter, iDGParameter, iDDParameter);
        }
    
        public virtual ObjectResult<pr_LoadPrepod_Result> pr_LoadPrepod()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_LoadPrepod_Result>("pr_LoadPrepod");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}