﻿using RT.Catalog.Data.Base;
using RT.Catalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace RT.Catalog.Data
{
    /// <summary>
    /// Database context for current application
    /// </summary>
    public class ApplicationDbContext:DbContextBase, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        #region System

        public DbSet<Log> Logs { get; set; }

        public DbSet<ApplicationUserProfile> Profiles { get; set; }

        /// <inheritdoc />
        public DbSet<MicroservicePermission> Permissions { get; set; }

        #endregion
    }
}