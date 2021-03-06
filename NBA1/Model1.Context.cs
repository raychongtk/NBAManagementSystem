﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NBA1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NBAEntities : DbContext
    {
        public NBAEntities()
            : base("name=NBAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Matchup> Matchups { get; set; }
        public virtual DbSet<MatchupDetail> MatchupDetails { get; set; }
        public virtual DbSet<MatchupLog> MatchupLogs { get; set; }
        public virtual DbSet<MatchupType> MatchupTypes { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayerInTeam> PlayerInTeams { get; set; }
        public virtual DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<PostSeason> PostSeasons { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
