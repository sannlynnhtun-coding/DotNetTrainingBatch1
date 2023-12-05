function successMessage(message) {
  Swal.fire({
    title: "Success!",
    text: message,
    icon: "success",
  });
}

function warningMessage(message) {
  Swal.fire({
    title: "Warning!",
    text: message,
    icon: "warning",
  });
}

function uuidv4() {
  return "10000000-1000-4000-8000-100000000000".replace(/[018]/g, (c) =>
    (
      c ^
      (crypto.getRandomValues(new Uint8Array(1))[0] & (15 >> (c / 4)))
    ).toString(16)
  );
}

// function confirmMessage(message) {
//     return new Promise((resolve, reject) => {
//         Swal.fire({
//             title: "Confirm",
//             text: message,
//             icon: "warning",
//             showCancelButton: true,
//         }).then((result) => {
//             // return result.isConfirmed;
//             resolve(result.isConfirmed)
//         });
//     });
// }
function confirmMessage(message) {
  return new Promise((resolve, reject) => {
    Notiflix.Confirm.show(
      "Confirm",
      message,
      "Yes",
      "No",
      function okCb() {
        resolve(true);
      },
      function cancelCb() {
        resolve(false);
      },
      {}
    );
  });
}

function readUser() {
  $("#tbTbody").html("");

  var users = localStorage.getItem("tbl_user");
  users = JSON.parse(users);

  let htmlString = "";
  $.each(users, function (index, value) {
    console.log(index + ": " + value.UserName);

    htmlString += `
                      <tr>
                          <td>
                              <button type="button" class="btn btn-warning" onclick="editUser('${
                                value.UserId
                              }')">
                                  <i class="fa-solid fa-pen-to-square"></i>
                              </button>
                              <button type="button" class="btn btn-danger" onclick="deleteUser('${
                                value.UserId
                              }')">
                                  <i class="fa-solid fa-trash"></i>
                              </button>
                          </td>
                          <td>${index + 1}</td>
                          <td>${value.UserName}</td>
                          <td>${value.UserMail}</td>
                          <td>${value.Date}</td>
                          <td>${value.Option1}</td>

                      </tr>`;
  });

  $("#tbTbody").html(htmlString);
}

function resetFormAndReadUser() {
  $("#txtUserName").val("");
  $("#txtUserName").focus();
  readUser();
}
