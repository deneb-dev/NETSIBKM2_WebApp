// $.ajax({
//     url: "https://pokeapi.co/api/v2/pokemon/",
//     success: function(result) {
//         let textTemp = "";
//         $.each(result.results, function(key, val) {
//             textTemp += `<tr>
//                             <td>${key+1}</td>
//                             <td>${val.name}</td>
//                             <td><button class="btn btn-primary" onclick="detailModal('${val.url}')" data-bs-toggle="modal" data-bs-target="#modalDetailPoke">Detail</button></td>
//                         </tr>`
//         })
//         $("tbody").html(textTemp);
//     }
// })

function detailModal(urlList) {
    console.log(urlList);

    $.ajax({
        url: urlList
    }).done((result) => {
        let img = "";
        img += `<center><img height = "200" width = "250"
        src = "${result.sprites.other.home.front_default}" alt=""</center>`;

        $("h1.modal-title").html(result.name);
        $("p.modal-img").html(img);
        $("p.modal-jurus").html("Jurus :" + result.moves[0].move.name);
        $("p.modal-tinggi").html("Tinggi :" + result.height);
        $("p.modal-berat").html("Berat :" + result.weight);
        // $("img.modal-body").html(result.sprites.front_default);

    })
}

// Document Reday Function
$(document).ready(function () {
    $('#tablePokeId').DataTable({
        "ajax": {
            url: "https://pokeapi.co/api/v2/pokemon/",
            dataSrc: 'results',
            dataType: "JSON"
        },
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "columns": [{
            "data": "id",
            "render": function (data, type, row, meta) {
                return meta.row + meta.settings._iDisplayStart + 1;
            }
        },
        {
            "data": "name"
        },
        {
            "data": "url",
            "render": function (data, type, row) {
                return `<button class="btn btn-primary" onclick="detailModal('${data}')" data-bs-toggle="modal" data-bs-target="#modalDetailPoke">Detail</button>`;
            }
        }
        ]
    });

});