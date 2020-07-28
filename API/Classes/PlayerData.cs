﻿// ReSharper disable ClassWithVirtualMembersNeverInherited.Global

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustalorc.PlayerInfoLib.Unturned.API.Classes
{
    public class PlayerData
    {
        [Column("Id", TypeName = "BIGINT UNSIGNED")]
        [Key]
        [Required]
        public ulong Id { get; set; }

        [Required] [StringLength(64)] public string SteamName { get; set; }

        [Required] [StringLength(64)] public string CharacterName { get; set; }

        [Required] [StringLength(64)] public string ProfilePictureHash { get; set; }

        [Column("LastQuestGroupId", TypeName = "BIGINT UNSIGNED")]
        [Required]
        [DefaultValue(0)]
        public ulong LastQuestGroupId { get; set; }

        [Column("SteamGroup", TypeName = "BIGINT UNSIGNED")]
        [Required]
        [DefaultValue(0)]
        public ulong SteamGroup { get; set; }

        [Required]
        [StringLength(64)]
        [DefaultValue("N/A")]
        public string SteamGroupName { get; set; }

        [Required] public string Hwid { get; set; }

        [Required] public long Ip { get; set; }

        [Required] [DefaultValue(0)] public double TotalPlaytime { get; set; }

        [Required] public DateTime LastLoginGlobal { get; set; }

        [Required] public int ServerId { get; set; }
        public virtual Server Server { get; set; }
    }
}