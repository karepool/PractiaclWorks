using Lesson8.Entity;
using System.Xml;
using System.Xml.Linq;

namespace Lesson8;

public static class Task4 {
    public static void StartTask() {
        Person person = new Person { Address = new Address(), Phones = new Phones()};

        Console.Write("Enter Full Name: ");
        person.FullName = Console.ReadLine();

        Console.Write("Enter Street: ");
        person.Address.Street = Console.ReadLine();

        Console.Write("Enter House Number: ");
        person.Address.HouseNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Flat Number: ");
        person.Address.FlatNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Mobile Phone: ");
        person.Phones.MobilePhone = Console.ReadLine();

        Console.Write("Enter Flat Phone: ");
        person.Phones.FlatPhone = Console.ReadLine();

        XmlDocument xDoc = new XmlDocument();
        xDoc.Load("people.xml");
        XmlElement? xRoot = xDoc.DocumentElement;

        XmlElement personElem = xDoc.CreateElement("Person");
        XmlAttribute nameAttr = xDoc.CreateAttribute("name");

        XmlElement addressElem = xDoc.CreateElement("Address");
        XmlElement streetElem = xDoc.CreateElement("Street");
        XmlElement houseNumberElem = xDoc.CreateElement("HouseNumber");
        XmlElement flatNumberElem = xDoc.CreateElement("FlatNumber");

        XmlElement phonesElem = xDoc.CreateElement("Phones");
        XmlElement mobilePhoneElem = xDoc.CreateElement("MobilePhone");
        XmlElement flatPhoneElem = xDoc.CreateElement("FlatPhone");

        xRoot?.AppendChild(personElem);

        personElem.Attributes.Append(nameAttr);

        personElem.AppendChild(addressElem);
        addressElem.AppendChild(streetElem);
        addressElem.AppendChild(houseNumberElem);
        addressElem.AppendChild(flatNumberElem);

        personElem.AppendChild(phonesElem);
        phonesElem.AppendChild(mobilePhoneElem);
        phonesElem.AppendChild(flatPhoneElem);
        
        XmlText nameText = xDoc.CreateTextNode(person.FullName);
        XmlText streetText = xDoc.CreateTextNode(person.Address.Street);
        XmlText houseNumberText = xDoc.CreateTextNode(person.Address.HouseNumber.ToString());
        XmlText flatNumberText = xDoc.CreateTextNode(person.Address.FlatNumber.ToString());
        XmlText mobilePhoneText = xDoc.CreateTextNode(person.Phones.MobilePhone);
        XmlText flatPhoneText = xDoc.CreateTextNode(person.Phones.FlatPhone);

        nameAttr.AppendChild(nameText);
        streetElem.AppendChild(streetText);
        houseNumberElem.AppendChild(houseNumberText);
        flatNumberElem.AppendChild(flatNumberText);
        mobilePhoneElem.AppendChild(mobilePhoneText);
        flatPhoneElem.AppendChild(flatPhoneText);
        
        xDoc.Save("people.xml");
    }
}