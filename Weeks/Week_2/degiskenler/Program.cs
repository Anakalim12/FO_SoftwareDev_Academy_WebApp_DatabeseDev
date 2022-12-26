// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

byte b = 5;             //1 byte yer kaplar

sbyte c = 5;            //1 byte yer kaplar

short s = 5;            //2 Byte yer kaplar
ushort us =5;           //2 Byte yer kaplar

//int16 i16 = 2;          //2 Byte yer kaplar
int i =2;               //4 Byter yer kaplar
//int32 i32 = 2;          //4 Byte yer kaplar
//int64 i64 = 2;          //8 Byte yer kaplar

uint ui = 2;            //4 Byte yer kaplar
long l = 2;             //8 Byte yer kaplar
ulong ul = 2;           //8 Byte yer kaplar

float f =2;           //4 Byte yer kaplar
double d = 5;         //8 Byte yer kaplar
decimal de = 5;       //16 Byte yer kaplar

char ch = '2';          //2 Byte yer kaplar
string str = "Mesut";    //sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;


//String  ifadeler
string str1 = string.Empty;
str1 = "Deniz Merve SARA";
string ad = "Mesut";
string soyad = "SARA";
string tamisim = ad + " " + soyad;

//integer değişkenler

int integer1 = 5;
int integer2 = 3;
int integer3= integer1 * integer2;

//Değişken dönüşümleri

string str20 = "20";
int = int20 = 20;

string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str20); //Çıktı 40 - parse execption olarak kullanılır - str20 string durumunda bir sayı değil ise hata verir




