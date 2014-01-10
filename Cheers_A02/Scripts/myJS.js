     $(document).ready(function () {
         var guidTable = $("#guidTable").val();
         if (Modernizr.localstorage) {
             var storedGuid = localStorage.getItem("CheersPersonalId");
             if (storedGuid == null) {
                 //TODO forward to login and assign a GUID for user account.. for now, do random one:
                 storedGuid = GUID();
                 localStorage.setItem("CheersPersonalId",storedGuid);
             }
             var strstoredGuid = storedGuid.toString();
             $.ajax({
                 type: "POST",
                 url: "AJAXCheckIn",
                 contentType: "application/json;charset=utf-8",
                 data: '{"guidTable":"' + guidTable + '", "guidPerson":"' + strstoredGuid + '"}',
                 dataType:"json",
                 success: function (count) { postCount(count);}
             });

             //alert(storedGuid);
              
         } else {
             alert("this garbage dont work. sheit.");
         }
     });
     function postCount(count) {
         $('#counter').html(count);
     }
function GUID() {
    var S4 = function () {
        return Math.floor(
                Math.random() * 0x10000 /* 65536 */
            ).toString(16);
    };

    return (
            S4() + S4() + "-" +
            S4() + "-" +
            S4() + "-" +
            S4() + "-" +
            S4() + S4() + S4()
        );
}