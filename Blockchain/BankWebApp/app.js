var contract;

$(function () {
  const web3 = new Web3(Web3.givenProvider || "ws://localhost:5500");

  var address = "0x519F95e2C721824FD1baCeC37905D692BBE3313f";
  var abi = [
    {
      inputs: [],
      stateMutability: "nonpayable",
      type: "constructor",
    },
    {
      inputs: [
        {
          internalType: "int256",
          name: "amt",
          type: "int256",
        },
      ],
      name: "Deposit",
      outputs: [],
      stateMutability: "nonpayable",
      type: "function",
    },
    {
      inputs: [],
      name: "GetBal",
      outputs: [
        {
          internalType: "int256",
          name: "",
          type: "int256",
        },
      ],
      stateMutability: "view",
      type: "function",
    },
    {
      inputs: [
        {
          internalType: "int256",
          name: "amount",
          type: "int256",
        },
      ],
      name: "Withdraw",
      outputs: [],
      stateMutability: "nonpayable",
      type: "function",
    },
  ];
  contract = new web3.eth.Contract(abi, address);

  contract.methods
    .GetBal()
    .call()
    .then(function (bal) {
      $("#lblBalance").html("Balance : " + bal);
    });

  $("#btnDeposit").on("click", function () {
    console.log("Deposit process triggered");

    var amt = parseInt($("#txtAmount").val());
    var ctrlId = "lblBalance";

    web3.eth
      .requestAccounts()
      .then(function (accounts) {
        var acc = accounts[0];
        return contract.methods.Deposit(amt).send({ from: acc });
      })
      .then(function (res) {
        console.log(res);

        $("#" + ctrlId).html("");

        contract.methods
          .GetBal()
          .call()
          .then(function (bal) {
            $("#" + ctrlId).html("Balance : " + bal);
          });
      })
      .catch(function (err) {
        console.log(err);
      });

    console.log("Deposit process ended");
  });

  $("#btnWithdraw").on("click", function () {
    console.log("Withdraw process triggered");
    var amt = parseInt($("#txtAmount").val());
    var ctrlId = "lblBalance";

    web3.eth
      .requestAccounts()
      .then(function (accounts) {
        var acc = accounts[0];
        return contract.methods.Withdraw(amt).send({ from: acc });
      })
      .then(function (res) {
        console.log(res);

        $("#" + ctrlId).html("");

        contract.methods
          .GetBal()
          .call()
          .then(function (bal) {
            $("#" + ctrlId).html("Balance : " + bal);
          });
      })
      .catch(function (err) {
        console.log(err);
      });

    console.log("Withdraw process ended");
  });

  function SendTran(amt, ctrlId) {}
});
