using System;
using System.Collections.Generic;
using System.Globalization;

namespace PolymorphismTasks;

internal class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        RunTask1();
        RunTask2();
        RunTask3();
        RunTask4();
        RunTask5();
        RunTask6();
        RunTask7();
        RunTask8();
        RunTask9();
        RunTask10();

        RunTask11();
        RunTask12();
        RunTask13();
        RunTask14();
        RunTask15();
        RunTask16();
        RunTask17();
        RunTask18();
        RunTask19();
        RunTask20();
        RunTask21();
        RunTask22();
        RunTask23();
        RunTask24();
        RunTask25();
        RunTask26();
        RunTask27();
        RunTask28();
        RunTask29();
        RunTask30();
    }

    static void PrintHeader(string title)
    {
        Console.WriteLine($"\n=== {title} ===");
    }

    static void RunTask1()
    {
        PrintHeader("1. Животные");
        List<Animal> animals = new() { new Dog(), new Cat(), new Cow() };
        foreach (var animal in animals)
            Console.WriteLine(animal.MakeSound());
    }

    static void RunTask2()
    {
        PrintHeader("2. Транспорт");
        List<Vehicle> vehicles = new() { new Car(), new Bike(), new Bus() };
        foreach (var vehicle in vehicles)
            Console.WriteLine(vehicle.Move());
    }

    static void RunTask3()
    {
        PrintHeader("3. Работники");
        List<Employee> employees = new() { new Programmer(), new Teacher(), new Doctor() };
        foreach (var employee in employees)
            Console.WriteLine(employee.Work());
    }

    static void RunTask4()
    {
        PrintHeader("4. Фигуры");
        List<Shape> shapes = new() { new Rectangle(4, 5), new Circle(3), new Triangle(3, 4, 5) };
        foreach (var shape in shapes)
            Console.WriteLine($"{shape.GetType().Name}: площадь = {shape.GetArea():F2}");
    }

    static void RunTask5()
    {
        PrintHeader("5. Банковские счета");
        List<BankAccount> accounts = new() { new SavingsAccount(1000m), new BusinessAccount(2000m) };
        foreach (var account in accounts)
            Console.WriteLine($"{account.GetType().Name}: процент = {account.CalculateInterest():C}");
    }

    static void RunTask6()
    {
        PrintHeader("6. Игроки");
        List<Player> players = new() { new Warrior(), new Archer(), new Mage() };
        foreach (var player in players)
            Console.WriteLine(player.Attack());
    }

    static void RunTask7()
    {
        PrintHeader("7. Устройства");
        List<Device> devices = new() { new Phone(), new Computer(), new Television() };
        foreach (var device in devices)
            Console.WriteLine(device.TurnOn());
    }

    static void RunTask8()
    {
        PrintHeader("8. Музыкальные инструменты");
        List<Instrument> instruments = new() { new Guitar(), new Piano(), new Drums() };
        foreach (var instrument in instruments)
            Console.WriteLine(instrument.Play());
    }

    static void RunTask9()
    {
        PrintHeader("9. Птицы");
        List<Bird> birds = new() { new Eagle(), new Penguin(), new Sparrow() };
        foreach (var bird in birds)
            Console.WriteLine(bird.Fly());
    }

    static void RunTask10()
    {
        PrintHeader("10. Сотрудники и зарплата");
        List<SalaryEmployee> employees = new() { new Manager(), new Developer(), new Intern() };
        foreach (var employee in employees)
            Console.WriteLine($"{employee.GetType().Name}: {employee.CalculateSalary():C}");
    }

    static void RunTask11()
    {
        PrintHeader("11. Система оплаты");
        List<Payment> payments = new() { new CashPayment(), new CardPayment(), new CryptoPayment() };
        foreach (var payment in payments)
            Console.WriteLine(payment.Pay());
    }

    static void RunTask12()
    {
        PrintHeader("12. Уведомления");
        List<Notification> notifications = new() { new EmailNotification(), new SmsNotification(), new PushNotification() };
        foreach (var notification in notifications)
            Console.WriteLine(notification.Send());
    }

    static void RunTask13()
    {
        PrintHeader("13. Доставка");
        List<Delivery> deliveries = new() { new CourierDelivery(), new PostDelivery(), new ExpressDelivery() };
        foreach (var delivery in deliveries)
            Console.WriteLine($"{delivery.GetType().Name}: {delivery.CalculatePrice():C}");
    }

    static void RunTask14()
    {
        PrintHeader("14. Система скидок");
        List<Discount> discounts = new() { new StudentDiscount(), new VipDiscount(), new SeasonalDiscount() };
        foreach (var discount in discounts)
            Console.WriteLine($"{discount.GetType().Name}: {discount.CalculateDiscount(1500m):C}");
    }

    static void RunTask15()
    {
        PrintHeader("15. Роботы");
        List<Robot> robots = new() { new CleaningRobot(), new SecurityRobot(), new DeliveryRobot() };
        foreach (var robot in robots)
            Console.WriteLine(robot.PerformTask());
    }

    static void RunTask16()
    {
        PrintHeader("16. Геометрические фигуры");
        List<AbstractShape> shapes = new() { new CircleShape(5), new RectangleShape(4, 6), new SquareShape(3), new TriangleShape(3, 4, 5) };
        foreach (var shape in shapes)
            Console.WriteLine($"{shape.GetType().Name}: площадь = {shape.GetArea():F2}, периметр = {shape.GetPerimeter():F2}");
    }

    static void RunTask17()
    {
        PrintHeader("17. Система транспорта");
        List<Transport> transports = new() { new CarTransport(120), new Train(90), new Airplane(500), new Ship(40) };
        foreach (var transport in transports)
            Console.WriteLine($"{transport.GetType().Name}: скорость = {transport.GetSpeed()} км/ч");
    }

    static void RunTask18()
    {
        PrintHeader("18. Зарплата сотрудников");
        List<EmployeeWithSalary> employees = new() { new ManagerSalary(), new DeveloperSalary(), new SalesManager() };
        foreach (var employee in employees)
            Console.WriteLine($"{employee.GetType().Name}: заработок = {employee.CalculateSalary():C}");
    }

    static void RunTask19()
    {
        PrintHeader("19. Интернет-магазин");
        List<ProductItem> products = new() { new ElectronicsProduct("Телефон", 999m), new FoodProduct("Яблоки", 40m), new ClothingProduct("Футболка", 120m) };
        foreach (var product in products)
            Console.WriteLine($"{product.Name}: итоговая цена = {product.GetFinalPrice():C}");
    }

    static void RunTask20()
    {
        PrintHeader("20. Система сообщений");
        List<IMessageSender> senders = new() { new EmailSender(), new SmsSender(), new TelegramSender() };
        foreach (var sender in senders)
            Console.WriteLine(sender.SendMessage("Привет!"));
    }

    static void RunTask21()
    {
        PrintHeader("21. Платёжная система");
        List<IPaymentMethod> methods = new() { new BankCard(), new PayPal(), new CryptoWallet() };
        foreach (var method in methods)
            Console.WriteLine(method.Pay());
    }

    static void RunTask22()
    {
        PrintHeader("22. Сотрудники компании");
        List<CompanyEmployee> employees = new() { new DeveloperEmployee(), new ManagerEmployee(), new DesignerEmployee(), new TesterEmployee() };
        foreach (var employee in employees)
            Console.WriteLine($"{employee.GetType().Name}: {employee.Work()} | {employee.CalculateSalary():C}");
    }

    static void RunTask23()
    {
        PrintHeader("23. Игра — персонажи");
        List<Character> party = new() { new WarriorCharacter(), new MageCharacter(), new ArcherCharacter(), new AssassinCharacter() };
        foreach (var character in party)
            Console.WriteLine(character.Attack());
    }

    static void RunTask24()
    {
        PrintHeader("24. Больница");
        List<MedicalWorker> workers = new() { new HospitalDoctor(), new HospitalSurgeon(), new HospitalNurse(), new HospitalDentist() };
        foreach (var worker in workers)
            Console.WriteLine(worker.TreatPatient());
    }

    static void RunTask25()
    {
        PrintHeader("25. Файловая система");
        List<FileSystemItem> files = new() { new TextFile(), new ImageFile(), new VideoFile(), new AudioFile() };
        foreach (var file in files)
            Console.WriteLine(file.Open());
    }

    static void RunTask26()
    {
        PrintHeader("26. Система отчетов");
        List<IReport> reports = new() { new SalesReport(), new FinancialReport(), new EmployeeReport() };
        foreach (var report in reports)
            Console.WriteLine(report.Generate());
    }

    static void RunTask27()
    {
        PrintHeader("27. Умный дом");
        var controller = new SmartHomeController();
        controller.Devices.Add(new SmartLight());
        controller.Devices.Add(new SmartTv());
        controller.Devices.Add(new SmartThermostat());
        controller.Devices.Add(new SecurityCamera());
        controller.TurnOnAll();
        controller.TurnOffAll();
    }

    static void RunTask28()
    {
        PrintHeader("28. Система заказов");
        List<Order> orders = new() { new FoodOrder(), new ClothingOrder(), new ElectronicsOrder() };
        foreach (var order in orders)
            Console.WriteLine($"{order.GetType().Name}: итог = {order.CalculateTotal():C}");
    }

    static void RunTask29()
    {
        PrintHeader("29. Такси-сервис");
        List<IRide> rides = new() { new EconomyRide(), new ComfortRide(), new BusinessRide() };
        foreach (var ride in rides)
            Console.WriteLine(ride.StartRide());
        foreach (var ride in rides)
            Console.WriteLine($"{ride.GetType().Name}: стоимость = {ride.CalculateCost():C}");
    }

    static void RunTask30()
    {
        PrintHeader("30. Мини-система интернет-магазина");
        List<ProductCatalog> products = new()
        {
            new ElectronicsCatalog("Ноутбук", 1200m),
            new FoodCatalog("Фрукты", 150m),
            new ClothingCatalog("Куртка", 300m)
        };

        List<IDiscount> discounts = new()
        {
            new StudentDiscountPolicy(),
            new VipDiscountPolicy(),
            new SeasonalDiscountPolicy()
        };

        decimal total = 0m;
        foreach (var product in products)
        {
            decimal price = product.GetPrice();
            foreach (var discount in discounts)
                price = discount.Apply(price);

            total += price;
            Console.WriteLine($"{product.Name}: {price:C}");
        }

        Console.WriteLine($"Итоговая сумма: {total:C}");
    }
}

public class Animal
{
    public virtual string MakeSound() => "Животное издаёт звук";
}

public class Dog : Animal { public override string MakeSound() => "Собака: гав-гав"; }
public class Cat : Animal { public override string MakeSound() => "Кот: мяу"; }
public class Cow : Animal { public override string MakeSound() => "Корова: муу"; }

public class Vehicle
{
    public virtual string Move() => "Транспорт движется";
}

public class Car : Vehicle { public override string Move() => "Автомобиль едет по дороге"; }
public class Bike : Vehicle { public override string Move() => "Велосипед едет по велодорожке"; }
public class Bus : Vehicle { public override string Move() => "Автобус движется по маршруту"; }

public class Employee
{
    public virtual string Work() => "Сотрудник работает";
}

public class Programmer : Employee { public override string Work() => "Программист пишет код"; }
public class Teacher : Employee { public override string Work() => "Учитель ведёт урок"; }
public class Doctor : Employee { public override string Work() => "Врач принимает пациентов"; }

public class Shape
{
    public virtual double GetArea() => 0;
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }
    public Rectangle(double width, double height) { Width = width; Height = height; }
    public override double GetArea() => Width * Height;
}

public class Circle : Shape
{
    public double Radius { get; }
    public Circle(double radius) { Radius = radius; }
    public override double GetArea() => Math.PI * Radius * Radius;
}

public class Triangle : Shape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public Triangle(double a, double b, double c) { A = a; B = b; C = c; }
    public override double GetArea()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}

public class BankAccount
{
    public decimal Balance { get; protected set; }
    public virtual decimal CalculateInterest() => 0m;
}

public class SavingsAccount : BankAccount
{
    public SavingsAccount(decimal balance) => Balance = balance;
    public override decimal CalculateInterest() => Balance * 0.08m;
}

public class BusinessAccount : BankAccount
{
    public BusinessAccount(decimal balance) => Balance = balance;
    public override decimal CalculateInterest() => Balance * 0.12m;
}

public class Player
{
    public virtual string Attack() => "Игрок атакует";
}

public class Warrior : Player { public override string Attack() => "Воин наносит мощный удар"; }
public class Archer : Player { public override string Attack() => "Лучник выпускает стрелу"; }
public class Mage : Player { public override string Attack() => "Маг вызывает огненный шар"; }

public class Device
{
    public virtual string TurnOn() => "Устройство включено";
}

public class Phone : Device { public override string TurnOn() => "Телефон включён"; }
public class Computer : Device { public override string TurnOn() => "Компьютер включён"; }
public class Television : Device { public override string TurnOn() => "Телевизор включён"; }

public class Instrument
{
    public virtual string Play() => "Инструмент играет";
}

public class Guitar : Instrument { public override string Play() => "Гитара звучит мелодично"; }
public class Piano : Instrument { public override string Play() => "Пианино играет красивую мелодию"; }
public class Drums : Instrument { public override string Play() => "Барабаны громко бьют"; }

public class Bird
{
    public virtual string Fly() => "Птица летит";
}

public class Eagle : Bird { public override string Fly() => "Орел парит в небе"; }
public class Penguin : Bird { public override string Fly() => "Пингвин не летает"; }
public class Sparrow : Bird { public override string Fly() => "Воробей быстро летит"; }

public class SalaryEmployee
{
    public virtual decimal CalculateSalary() => 0m;
}

public class Manager : SalaryEmployee { public override decimal CalculateSalary() => 50000m; }
public class Developer : SalaryEmployee { public override decimal CalculateSalary() => 75000m; }
public class Intern : SalaryEmployee { public override decimal CalculateSalary() => 25000m; }

public class Payment
{
    public virtual string Pay() => "Оплата выполнена";
}

public class CashPayment : Payment { public override string Pay() => "Оплата наличными"; }
public class CardPayment : Payment { public override string Pay() => "Оплата картой"; }
public class CryptoPayment : Payment { public override string Pay() => "Оплата криптовалютой"; }

public class Notification
{
    public virtual string Send() => "Уведомление отправлено";
}

public class EmailNotification : Notification { public override string Send() => "Email-уведомление отправлено"; }
public class SmsNotification : Notification { public override string Send() => "SMS-сообщение отправлено"; }
public class PushNotification : Notification { public override string Send() => "Push-уведомление отправлено"; }

public class Delivery
{
    public virtual decimal CalculatePrice() => 0m;
}

public class CourierDelivery : Delivery { public override decimal CalculatePrice() => 150m; }
public class PostDelivery : Delivery { public override decimal CalculatePrice() => 80m; }
public class ExpressDelivery : Delivery { public override decimal CalculatePrice() => 300m; }

public class Discount
{
    public virtual decimal CalculateDiscount(decimal price) => price;
}

public class StudentDiscount : Discount { public override decimal CalculateDiscount(decimal price) => price * 0.90m; }
public class VipDiscount : Discount { public override decimal CalculateDiscount(decimal price) => price * 0.85m; }
public class SeasonalDiscount : Discount { public override decimal CalculateDiscount(decimal price) => price * 0.95m; }

public class Robot
{
    public virtual string PerformTask() => "Робот выполняет задачу";
}

public class CleaningRobot : Robot { public override string PerformTask() => "Робот убирает помещение"; }
public class SecurityRobot : Robot { public override string PerformTask() => "Робот охраняет объект"; }
public class DeliveryRobot : Robot { public override string PerformTask() => "Робот доставляет посылки"; }

public abstract class AbstractShape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

public class CircleShape : AbstractShape
{
    public double Radius { get; }
    public CircleShape(double radius) => Radius = radius;
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}

public class RectangleShape : AbstractShape
{
    public double Width { get; }
    public double Height { get; }
    public RectangleShape(double width, double height) { Width = width; Height = height; }
    public override double GetArea() => Width * Height;
    public override double GetPerimeter() => 2 * (Width + Height);
}

public class SquareShape : AbstractShape
{
    public double Side { get; }
    public SquareShape(double side) => Side = side;
    public override double GetArea() => Side * Side;
    public override double GetPerimeter() => 4 * Side;
}

public class TriangleShape : AbstractShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public TriangleShape(double a, double b, double c) { A = a; B = b; C = c; }
    public override double GetArea()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override double GetPerimeter() => A + B + C;
}

public abstract class Transport
{
    public abstract int GetSpeed();
}

public class CarTransport : Transport
{
    public int MaxSpeed { get; }
    public CarTransport(int maxSpeed) => MaxSpeed = maxSpeed;
    public override int GetSpeed() => MaxSpeed;
}

public class Train : Transport
{
    public int MaxSpeed { get; }
    public Train(int maxSpeed) => MaxSpeed = maxSpeed;
    public override int GetSpeed() => MaxSpeed;
}

public class Airplane : Transport
{
    public int MaxSpeed { get; }
    public Airplane(int maxSpeed) => MaxSpeed = maxSpeed;
    public override int GetSpeed() => MaxSpeed;
}

public class Ship : Transport
{
    public int MaxSpeed { get; }
    public Ship(int maxSpeed) => MaxSpeed = maxSpeed;
    public override int GetSpeed() => MaxSpeed;
}

public abstract class EmployeeWithSalary
{
    public abstract decimal CalculateSalary();
}

public class ManagerSalary : EmployeeWithSalary { public override decimal CalculateSalary() => 60000m; }
public class DeveloperSalary : EmployeeWithSalary { public override decimal CalculateSalary() => 80000m; }
public class SalesManager : EmployeeWithSalary { public override decimal CalculateSalary() => 65000m; }

public class ProductItem
{
    public string Name { get; }
    public decimal Price { get; }

    public ProductItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual decimal GetFinalPrice() => Price;
}

public class ElectronicsProduct : ProductItem
{
    public ElectronicsProduct(string name, decimal price) : base(name, price) { }
    public override decimal GetFinalPrice() => Price * 0.9m;
}

public class FoodProduct : ProductItem
{
    public FoodProduct(string name, decimal price) : base(name, price) { }
    public override decimal GetFinalPrice() => Price * 0.95m;
}

public class ClothingProduct : ProductItem
{
    public ClothingProduct(string name, decimal price) : base(name, price) { }
    public override decimal GetFinalPrice() => Price * 0.8m;
}

public interface IMessageSender
{
    string SendMessage(string message);
}

public class EmailSender : IMessageSender
{
    public string SendMessage(string message) => $"Email: {message}";
}

public class SmsSender : IMessageSender
{
    public string SendMessage(string message) => $"SMS: {message}";
}

public class TelegramSender : IMessageSender
{
    public string SendMessage(string message) => $"Telegram: {message}";
}

public interface IPaymentMethod
{
    string Pay();
    string Refund();
}

public class BankCard : IPaymentMethod
{
    public string Pay() => "Оплата банковской картой";
    public string Refund() => "Возврат по банковской карте";
}

public class PayPal : IPaymentMethod
{
    public string Pay() => "Оплата через PayPal";
    public string Refund() => "Возврат через PayPal";
}

public class CryptoWallet : IPaymentMethod
{
    public string Pay() => "Оплата криптокошельком";
    public string Refund() => "Возврат криптовалюты";
}

public abstract class CompanyEmployee
{
    public abstract string Work();
    public abstract decimal CalculateSalary();
}

public class DeveloperEmployee : CompanyEmployee
{
    public override string Work() => "Разрабатывает приложение";
    public override decimal CalculateSalary() => 90000m;
}

public class ManagerEmployee : CompanyEmployee
{
    public override string Work() => "Управляет проектом";
    public override decimal CalculateSalary() => 85000m;
}

public class DesignerEmployee : CompanyEmployee
{
    public override string Work() => "Создаёт дизайн";
    public override decimal CalculateSalary() => 70000m;
}

public class TesterEmployee : CompanyEmployee
{
    public override string Work() => "Проверяет качество";
    public override decimal CalculateSalary() => 60000m;
}

public abstract class Character
{
    public abstract string Attack();
}

public class WarriorCharacter : Character
{
    public override string Attack() => "Воин атакует мечом";
}

public class MageCharacter : Character
{
    public override string Attack() => "Маг запускает заклинание";
}

public class ArcherCharacter : Character
{
    public override string Attack() => "Лучник стреляет из лука";
}

public class AssassinCharacter : Character
{
    public override string Attack() => "Убийца наносит скрытую атаку";
}

public class MedicalWorker
{
    public virtual string TreatPatient() => "Медработник помогает пациенту";
}

public class HospitalDoctor : MedicalWorker { public override string TreatPatient() => "Врач назначает лечение"; }
public class HospitalSurgeon : MedicalWorker { public override string TreatPatient() => "Хирург проводит операцию"; }
public class HospitalNurse : MedicalWorker { public override string TreatPatient() => "Медсестра помогает с уходом"; }
public class HospitalDentist : MedicalWorker { public override string TreatPatient() => "Стоматолог лечит зубы"; }

public abstract class FileSystemItem
{
    public abstract string Open();
}

public class TextFile : FileSystemItem { public override string Open() => "Открыт текстовый файл"; }
public class ImageFile : FileSystemItem { public override string Open() => "Открыто изображение"; }
public class VideoFile : FileSystemItem { public override string Open() => "Открыто видео"; }
public class AudioFile : FileSystemItem { public override string Open() => "Открыто аудио"; }

public interface IReport
{
    string Generate();
}

public class SalesReport : IReport { public string Generate() => "Отчет по продажам сгенерирован"; }
public class FinancialReport : IReport { public string Generate() => "Финансовый отчет сгенерирован"; }
public class EmployeeReport : IReport { public string Generate() => "Отчет по сотрудникам сгенерирован"; }

public abstract class SmartDevice
{
    public virtual string TurnOn() => "Устройство включено";
    public virtual string TurnOff() => "Устройство выключено";
}

public class SmartLight : SmartDevice { public override string TurnOn() => "Лампа включена"; public override string TurnOff() => "Лампа выключена"; }
public class SmartTv : SmartDevice { public override string TurnOn() => "Телевизор включен"; public override string TurnOff() => "Телевизор выключен"; }
public class SmartThermostat : SmartDevice { public override string TurnOn() => "Термостат активирован"; public override string TurnOff() => "Термостат отключен"; }
public class SecurityCamera : SmartDevice { public override string TurnOn() => "Камера начала запись"; public override string TurnOff() => "Камера остановила запись"; }

public class SmartHomeController
{
    public List<SmartDevice> Devices { get; } = new();

    public void TurnOnAll()
    {
        foreach (var device in Devices)
            Console.WriteLine(device.TurnOn());
    }

    public void TurnOffAll()
    {
        foreach (var device in Devices)
            Console.WriteLine(device.TurnOff());
    }
}

public abstract class Order
{
    public abstract decimal CalculateTotal();
}

public class FoodOrder : Order { public override decimal CalculateTotal() => 350m; }
public class ClothingOrder : Order { public override decimal CalculateTotal() => 1200m; }
public class ElectronicsOrder : Order { public override decimal CalculateTotal() => 2500m; }

public interface IRide
{
    string StartRide();
    decimal CalculateCost();
}

public class EconomyRide : IRide
{
    public string StartRide() => "Эконом-класс: поездка началась";
    public decimal CalculateCost() => 200m;
}

public class ComfortRide : IRide
{
    public string StartRide() => "Комфорт: поездка началась";
    public decimal CalculateCost() => 400m;
}

public class BusinessRide : IRide
{
    public string StartRide() => "Бизнес: поездка началась";
    public decimal CalculateCost() => 700m;
}

public abstract class ProductCatalog
{
    public string Name { get; }
    public decimal Price { get; }

    protected ProductCatalog(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract decimal GetPrice();
}

public class ElectronicsCatalog : ProductCatalog
{
    public ElectronicsCatalog(string name, decimal price) : base(name, price) { }
    public override decimal GetPrice() => Price * 0.95m;
}

public class FoodCatalog : ProductCatalog
{
    public FoodCatalog(string name, decimal price) : base(name, price) { }
    public override decimal GetPrice() => Price * 0.90m;
}

public class ClothingCatalog : ProductCatalog
{
    public ClothingCatalog(string name, decimal price) : base(name, price) { }
    public override decimal GetPrice() => Price * 0.85m;
}

public interface IDiscount
{
    decimal Apply(decimal price);
}

public class StudentDiscountPolicy : IDiscount
{
    public decimal Apply(decimal price) => price * 0.90m;
}

public class VipDiscountPolicy : IDiscount
{
    public decimal Apply(decimal price) => price * 0.80m;
}

public class SeasonalDiscountPolicy : IDiscount
{
    public decimal Apply(decimal price) => price * 0.95m;
}

