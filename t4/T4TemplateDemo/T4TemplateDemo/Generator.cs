
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;

	public class TemplateEntities:DbContext
	{
		public TemplateEntities()
            : base(SingleConnection.GetConnection(),false)
        {
        }

        public AccessContext(string filePath)
    :       base(SingleConnection.GetConnection(filePath), false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
				
		public virtual DbSet<__MigrationHistory> __MigrationHistory { get; set; }
				
		public virtual DbSet<Attribute> Attribute { get; set; }
				
		public virtual DbSet<ComObject> ComObject { get; set; }
				
		public virtual DbSet<DisList> DisList { get; set; }
				
		public virtual DbSet<DisObject> DisObject { get; set; }
				
		public virtual DbSet<DisTable> DisTable { get; set; }
				
		public virtual DbSet<DisType> DisType { get; set; }
				
		public virtual DbSet<MainTable> MainTable { get; set; }
				
		public virtual DbSet<MainTables> MainTables { get; set; }
				
		public virtual DbSet<OrderByCode> OrderByCode { get; set; }
				
		public virtual DbSet<OtherDis> OtherDis { get; set; }
				
		public virtual DbSet<OutWall> OutWall { get; set; }
				
		public virtual DbSet<OutWallComDis> OutWallComDis { get; set; }
				
		public virtual DbSet<OutWallGroup> OutWallGroup { get; set; }
				
		public virtual DbSet<TempTable> TempTable { get; set; }
			 }

	public class __MigrationHistory
	{
	
		public string ContextKey {get;set;}
		
		public string MigrationId {get;set;}
		
		public string Model {get;set;}
		
		public string ProductVersion {get;set;}
				
	}

	public class Attribute
	{
	
		public double Area {get;set;}
		
		public double BalconyArea {get;set;}
		
		public string BCalFormular {get;set;}
		
		public string BlockID {get;set;}
		
		public string BlockName {get;set;}
		
		public string ColorIndex {get;set;}
		
		public string DisNum {get;set;}
		
		public int Floor {get;set;}
		
		public string HouseName {get;set;}
		
		public string HouseNumber {get;set;}
		
		public int ID {get;set;}
		
		public string InCalFormular {get;set;}
		
		public double InserX {get;set;}
		
		public double InserY {get;set;}
		
		public string ObjCode {get;set;}
		
		public string ObjKind {get;set;}
		
		public string SelState {get;set;}
				
	}

	public class ComObject
	{
	
		public double Area {get;set;}
		
		public string ComCode {get;set;}
		
		public double DisArea {get;set;}
		
		public int ID {get;set;}
				
	}

	public class DisList
	{
	
		public string BlockID {get;set;}
		
		public string ComCode {get;set;}
				
	}

	public class DisObject
	{
	
		public string Code {get;set;}
		
		public string Name {get;set;}
				
	}

	public class DisTable
	{
	
		public double Area {get;set;}
		
		public string BlockID {get;set;}
		
		public string ComCode {get;set;}
		
		public double DisArea {get;set;}
		
		public string Floor {get;set;}
		
		public int ID {get;set;}
		
		public string IsDis {get;set;}
		
		public string ObjCode {get;set;}
		
		public string ObjKind {get;set;}
		
		public string ObjName {get;set;}
				
	}

	public class DisType
	{
	
		public string GDisType {get;set;}
		
		public int ID {get;set;}
		
		public string IsApp {get;set;}
		
		public string MoreDisType {get;set;}
		
		public string OutWallDisType {get;set;}
		
		public string TDisType {get;set;}
				
	}

	public class MainTable
	{
	
		public double ApportionArea {get;set;}
		
		public double ApportionNum {get;set;}
		
		public double BalconyArea {get;set;}
		
		public string BCalFormular {get;set;}
		
		public string BlockID {get;set;}
		
		public string Build_Code {get;set;}
		
		public string Build_Name {get;set;}
		
		public double BuildArea {get;set;}
		
		public string ColorIndex {get;set;}
		
		public string DisNum {get;set;}
		
		public string DoorNum {get;set;}
		
		public string Finish_Year {get;set;}
		
		public int Floor {get;set;}
		
		public string Four_Code {get;set;}
		
		public string HouseClass {get;set;}
		
		public string HouseName {get;set;}
		
		public string HouseNum {get;set;}
		
		public string HouseNumber {get;set;}
		
		public int ID {get;set;}
		
		public double InArea {get;set;}
		
		public string InCalFormular {get;set;}
		
		public string Name {get;set;}
		
		public string Print_State {get;set;}
		
		public string Purpose_Code {get;set;}
		
		public string Purpose_Name {get;set;}
		
		public string String_Floor {get;set;}
		
		public string Structure_Class {get;set;}
		
		public string Structure_Name {get;set;}
				
	}

	public class MainTables
	{
	
		public int ID {get;set;}
				
	}

	public class OrderByCode
	{
	
		public string ComCode {get;set;}
		
		public int ID {get;set;}
		
		public string Type {get;set;}
				
	}

	public class OtherDis
	{
	
		public string ComCode {get;set;}
		
		public string DisHouseNum {get;set;}
		
		public string DoorNum {get;set;}
		
		public string HouseNum {get;set;}
		
		public int ID {get;set;}
				
	}

	public class OutWall
	{
	
		public double Area {get;set;}
		
		public string ComCode {get;set;}
		
		public double DisArea {get;set;}
		
		public int Floor {get;set;}
		
		public int ID {get;set;}
		
		public string Name {get;set;}
				
	}

	public class OutWallComDis
	{
	
		public double Area {get;set;}
		
		public string ComCode {get;set;}
		
		public string Floor {get;set;}
		
		public int ID {get;set;}
		
		public double TotalArea {get;set;}
				
	}

	public class OutWallGroup
	{
	
		public double Area {get;set;}
		
		public string Code {get;set;}
		
		public string ComCode {get;set;}
		
		public int Floor {get;set;}
		
		public int ID {get;set;}
		
		public string Lkk_Handle {get;set;}
		
		public string Lkx_Handle {get;set;}
				
	}

	public class TempTable
	{
	
		public double ApportionArea {get;set;}
		
		public double ApportionNum {get;set;}
		
		public double BalconyArea {get;set;}
		
		public string BCalFormular {get;set;}
		
		public string BlockID {get;set;}
		
		public string Build_Code {get;set;}
		
		public string Build_Name {get;set;}
		
		public double BuildArea {get;set;}
		
		public string ColorIndex {get;set;}
		
		public string DisNum {get;set;}
		
		public string DoorNum {get;set;}
		
		public string Finish_Year {get;set;}
		
		public int Floor {get;set;}
		
		public string Four_code {get;set;}
		
		public string HouseClass {get;set;}
		
		public string HouseName {get;set;}
		
		public string HouseNum {get;set;}
		
		public string HouseNumber {get;set;}
		
		public int ID {get;set;}
		
		public double InArea {get;set;}
		
		public string InCalFormular {get;set;}
		
		public string Name {get;set;}
		
		public string Print_State {get;set;}
		
		public string Purpose_Code {get;set;}
		
		public string Purpose_Name {get;set;}
		
		public string String_Floor {get;set;}
		
		public string Structure_Class {get;set;}
		
		public string Structure_Name {get;set;}
				
	}
