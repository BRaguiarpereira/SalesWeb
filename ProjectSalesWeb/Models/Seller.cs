﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace ProjectSalesWeb.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }

        // Imprementando a associação de Seller com Departament
        public Department Department { get; set; }
        // Imprementando a associação de Seller com SalesRecord
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        // Gerar constructor com todos os atributos menos as collections
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        //METODOS
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RevomeSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial , DateTime final)
        {
            return Sales
                .Where(sr => sr.Date >= initial && sr.Date <= final)
                .Sum(sr => sr.Amount);
        }
    }
}