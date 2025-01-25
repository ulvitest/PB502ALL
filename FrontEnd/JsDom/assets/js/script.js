//js dom
// console.log(document);
// document.write("<h1>salam</h1>")
// console.log(document.getElementById("list"));
// let h1=document.getElementById("text");
// h1.style.color="red";
// h1.style.backgroundColor="green";
// let h1=document.getElementsByTagName("h1");
// console.log( document.getElementsByClassName("list"));
// console.log(document.getElementsByTagName("h1"));
// let lies=document.querySelectorAll("ul li");
// console.log(lies);
// let li=document.querySelector("li")
// console.log(li);
// let h1=document.querySelector("#text");
// console.log(h1.getAttribute("id"));
// h1.setAttribute("class","lorem");
// console.log(h1.hasAttribute("id"));
// let list=document.getElementsByTagName("li");
// console.log(list);

// let li=document.createElement("li");
// li.innerText="<a href=''>salam</a>";
// li.innerHTML="<a href=''>salam</a>"
// list.appendChild(li);
// console.log(list);
// console.log(list.children);
// console.log(list.firstElementChild);
// console.log(list.lastElementChild);
// console.log(list.firstElementChild.nextElementSibling.nextElementSibling);
// console.log(list.lastElementChild.previousElementSibling.previousElementSibling);

// for (let li = 0; li < list.length; li++) {
//    list[li].remove();
// }
// document.querySelector("a").setAttribute("href","google.com");
// let button=document.getElementById("btn");
// button.onclick=function(){
//     let h1=this.previousElementSibling;
//     h1.style.color="white";
//     h1.style.backgroundColor="black";
// }
// function test(){
//     alert("hello");
// }
// button.onclick=()=>{
//     alert("salam");
// }
// button.addEventListener("click",function(){
//     alert("hello");
// })
// button.onclick=()=>{
//     alert("sagol");
// }
// let icon=document.querySelector(".icon");
// let button=document.querySelector(".button");
// let sidebar=document.querySelector(".sidebar");
// icon.onclick=function(){
  
//     // sidebar.className="test";
//     sidebar.classList.add("close");
//     // sidebar.classList.remove("");
    
// }
// button.onclick=function(){
// sidebar.classList.remove("close")
// }
// let btn=document.querySelector(".button");
// let input=document.querySelector(".input");
// let list=document.querySelector(".list");
// btn.addEventListener("click",()=>{

// if(!input.value){
//     alert("bosh qoyma");
//     return 
// }
// list.innerHTML="";
// for (let i = 1; i <= input.value; i++) {
  
   
//     let li=`<li class="list-group-item">${i}</li>`
//     list.innerHTML+=li;
// }
// input.value="";

// if(!input.value)
//  {
//     alert("bosh qoyma");
//     return;
//  }
// //  let li=document.createElement("li");
// //  li.innerText=input.value;
// //  li.classList.add("list-group-item");
// let li=`<li class="list-group-item">${input.value}</li>`
// list.innerHTML+=li;
//  input.value="";

// });
// document.getElementById("input").onchange=()=>{
//     console.log("input val changed..");
// }
// document.getElementById("input").onfocus=()=>{
//     console.log("input focus");
// }
// document.getElementById("input").onblur=()=>{
//     console.log("input blur");
// }
// document.getElementById("input").onkeyup=function(){
//     console.log(this.value);
// }
// document.getElementById("cars").onchange=function(){
//     console.log("value deyisdi...");
    
// }
// document.getElementById("form").onsubmit=function(ev){
//     ev.preventDefault();
//     Swal.fire({
//         title: "Good job!",
//         text: "You clicked the button!",
//         icon: "success"
//       });
// }
// let array=[23,56,23,100,37];
// console.log(array.reduce((prev,next,index,arr)=>prev+next,20));
// array.findLast(num=>num==23);

// array.forEach((value)=>{
//     console.log(value);
    
// })
// let newArr=array.map((value)=>value*2)
// console.log(newArr);
// let newArr=array.filter((value)=>value!=11);
// console.log(newArr);
// console.log(array.every((value)=>value>20));
// console.log(array.some((value)=>value>20));




// let arr=[];
// for (let i = 0; i < array.length; i++) {
    
//     arr.push(array[i]*2)
// }
// console.log(arr);

// function Sum(cb){
//     let sum=0;
//     for (let i = 0; i < array.length; i++) {
//       if(cb(array[i]))
//         sum+=array[i];
        
//     }
//     console.log(sum);
    
// }
// Sum(n=>n>10);
let posts=[
      {
        "userId": 1,
        "id": 1,
        "title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
        "body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
      },
      {
        "userId": 1,
        "id": 2,
        "title": "qui est esse",
        "body": "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla"
      },
      {
        "userId": 1,
        "id": 3,
        "title": "ea molestias quasi exercitationem repellat qui ipsa sit aut",
        "body": "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut"
      },
      {
        "userId": 1,
        "id": 4,
        "title": "eum et est occaecati",
        "body": "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit"
      },
      {
        "userId": 1,
        "id": 5,
        "title": "nesciunt quas odio",
        "body": "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque"
      },
      {
        "userId": 1,
        "id": 6,
        "title": "dolorem eum magni eos aperiam quia",
        "body": "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae"
      },
]
// console.log(posts.filter(value=>value.id>4).reduce((total,next)=>total+next.id,0));
// posts.forEach(value=>{
//     console.log(value);
    
// })

// let date=new Date();
// console.log(date.getHours());
// console.log(date.getMinutes());
// console.log(date.getSeconds());
// setTimeout(function(){
// alert("hello..")
// },2000)
// setInterval(()=>{
//     console.log("salam");
    
// },2000)
function getDate(){
    let date=new Date();
    let hour=date.getHours()>10?date.getHours():"0"+date.getHours();
    let second=date.getSeconds()>10?date.getSeconds():"0"+date.getSeconds();
    let minutes=date.getMinutes()>10?date.getMinutes():"0"+date.getMinutes();
    document.getElementById("watch").innerText=`${hour}:${minutes}:${second}`
}
setInterval(getDate, 1000);




















