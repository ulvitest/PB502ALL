//alert("Salam");
//console.log("salam");
// console.log(document);//dom
// document.write("salam");
//var const let 

//console.log(age);
//var age=12;
// age="lorem";
//hoisting
//var age=14;

// console.log(address);
// let address="Baki";
// let address="";
//address=12;

// console.log(point);
// const point=66;

//scope=>block,global,function
// let isSucces=true;
// if(isSucces){
//     // console.log("ugurlu");
// }
// else
//    console.log("ugursuz..");


// if (true) {
//     let num=12;
// }

// let sum=0;
// if(true){
//   let num1=12;
//   let num2=14;
//   let sum=num1+num2;
//   console.log(sum);

// }

// function Sum(){
//     console.log(num);
//     let num=12;
// }
// Sum();

// let num=12;
// console.log(typeof typeof num);
// let name="Cavid";
// console.log(typeof name);
// let isSucces=true;
// console.log(typeof isSucces);
// let numberr=1111111n;
// console.log(typeof numberr);
// let lorem=null;
// console.log(typeof null);
// let undefineddd=undefined;
// console.log(typeof undefineddd);

// let age=10;
// if(age>18){
//     console.log("giris ugurludur");

// }
// else if(age==18){
//     console.log("18dir..");

// }
// else{
//     console.log("giris ugursuzdur..");

// }
// let day = 1;
// switch (day) {
//     case 1:
//     case 2:
//         console.log("1 ve ya 2ci gun");
//         break;

//     default:
//         break;
// }
// const age=20;
// try {
//     // age=13;
//    throw  new Error("something went..")
// } catch (error) {
//     console.log(error);
    
// }
// finally{

// }

// let numbers=[12,13,1,66,20,"lorem",false];
// let numbers=[12,13,1,66,20];
// console.log(numbers[5][0]);
// console.log(numbers[0]);
// console.log(numbers[numbers.length-1]);
// console.log(numbers.length);
// numbers.push(55);
// numbers.pop();
// numbers.shift();
// numbers.unshift(111);
// console.log(numbers);
// for (let i = 0; i < numbers.length; i++) {
//     const element = numbers[i];
//     console.log(element); 
// }
// debugger;
// let max=numbers[0];
// for (let i = 0; i < numbers.length; i++) {
//    if (max<numbers[i]) {
//     max=numbers[i]
//    }
    
// }
// console.log(max);
// let user={
//     name:"Asif",
//     age:19,
//     address:"Baki",
//     "fullname of student":"filankes filankesov"
// };
// user="";
// user.password="";
// console.log(user.age);
// console.log(user["fullname of student"]);
// user.point=100;
//delete user.name;
 //console.log(user);
//  let objects=[user,11,44,{group:"pb502",limit:20}];
//  console.log(typeof objects);

//  truthy :any numbers without 0,{},[]
//  falsy   :null,undefined,0,""
// if([]){
//    console.log("okay");
// }
// else{
//     console.log("not okay");
    
// }
// let numbers=[];
// if (numbers.length) {
//     console.log("okay");
// }
// let num=+prompt("enter number :");
// console.log(num);
// console.log(parseInt("12a"));
// console.log(isNaN("12"));
// let num=new Number("12");
// console.log(num);
// let numbers=[11,44,10];
// let sum=0;
// for (let i = 0; i < numbers.length; i++) {
//    sum+=numbers[i]
    
// }
// let age=prompt("enter age: ");
// console.log(`student age is ${age}`);

// Info();
// function Info(){
//     console.log("hello ");
// }
// function  Sum(a) {
//    console.log(Array.from(arguments));
// }
//  console.log(Sum(11,22,33,44,66));
// console.log(sum(2,3));
// let sum=(a,b)=>a+b;

// let info=(surname,age)=>({
//     surname,
//     age
//  })
// let {surname,age}=info("lorem",20);
// let word="loremipsum lorem";
// console.log(word.length);
// console.log(word.slice(-5));
// console.log(word.substring(-4));
// console.log(word+" "+"abc");
// console.log(word.concat(" ","abc"));
// console.log(word.repeat(3));
// console.log(word.replace(/loreM/i,"doler"));
// console.log(word.replace(/Lorem/ig,"doler"));
let user={
    age:12,
    address:"Baki",
    getAge:function(){
        return user.age;
    },
    getUserAge:()=>{
        return this.age;
    }
};
// Object.freeze(user);
// user.point=24;
// console.log(user);
// console.log(Object.keys(user));
// console.log(Object.values(user));
//console.log(Object.entries(user));//[[age,12],[address,baki]]
// Object.defineProperty(user,"point",{value:123,writable:false});
// user.point=200;
// console.log(user);





//console.log(user.age);
// console.log(window);
// console.log(user.getUserAge());
























 




















