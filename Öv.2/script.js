function showMessage(message)
{
    document.getElementById('message').textContent = message;
}
function undef(message)
{
    document.getElementById('undef').textContent = message;
}
function volvo()
{
    let a1 = "Volvo"   
    console.log(a1) 
    return (a1);
}
showMessage(typeof volvo() +" "+ volvo());
undef(typeof a1)