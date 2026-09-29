using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServeHub.Domain.Entities;
using ServeHub.Domain.Enums;
using ServeHub.Infrastructure.Identity;
using System.Data;

namespace ServeHub.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserPhone> UserPhones { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductMedia> ProductMedias { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductOptionType> ProductOptionTypes { get; set; }
        public DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public DbSet<ProductVariantOptionValue> ProductVariantOptionValues { get; set; }
        public DbSet<BranchEmployee> BranchEmployees { get; set; }
        public DbSet<BranchCategory> BranchCategories { get; set; }
        public DbSet<BranchProductVariant> BranchProductVariants { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatusHistory> OrderStatusHistories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceUsage> ServiceUsages { get; set; }
        public DbSet<CashShift> CashShifts { get; set; }
        public DbSet<CashMovement> CashMovements { get; set; }
        public DbSet<CustomerTab> CustomerTabs { get; set; }
        public DbSet<TabTransaction> TabTransactions { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<SalaryConfig> SalaryConfigs { get; set; }
        public DbSet<StaffTransaction> StaffTransactions { get; set; }
        public DbSet<SalaryPayment> SalaryPayments { get; set; }
        public DbSet<WorkLog> WorkLogs { get; set; }
        public DbSet<DomainRole> DomainRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            var enumTypes = typeof(EmpStatus).Assembly
                .GetTypes()
                .Where(t => t.IsEnum && t.IsVisible && t.Namespace == typeof(EmpStatus).Namespace);

            foreach (var enumType in enumTypes)
            {
                configurationBuilder.Properties(enumType)
                    .HaveConversion<string>()
                    .HaveMaxLength(50);
            }

            configurationBuilder.Properties<decimal>().HavePrecision(18, 2);
        }
    }
}