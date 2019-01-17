//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Matchup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matchup()
        {
            this.MatchupLogs = new HashSet<MatchupLog>();
            this.MatchupDetails = new HashSet<MatchupDetail>();
            this.PlayerStatistics = new HashSet<PlayerStatistic>();
        }
    
        public int MatchupId { get; set; }
        public int SeasonId { get; set; }
        public int MatchupTypeId { get; set; }
        public int Team_Away { get; set; }
        public int Team_Home { get; set; }
        public System.DateTime Starttime { get; set; }
        public int Team_Away_Score { get; set; }
        public int Team_Home_Score { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public string CurrentQuarter { get; set; }
    
        public virtual Season Season { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupLog> MatchupLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupDetail> MatchupDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
        public virtual MatchupType MatchupType { get; set; }
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
    }
}
