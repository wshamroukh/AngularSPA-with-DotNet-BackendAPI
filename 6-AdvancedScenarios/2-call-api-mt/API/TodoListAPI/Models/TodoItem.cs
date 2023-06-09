﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListAPI.Models
{
    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string OwnerTenantId { get; set; }
        public string OwnerDisplayName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}