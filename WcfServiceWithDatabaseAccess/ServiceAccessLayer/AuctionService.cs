﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.ControlLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionService" in both code and config file together.
    public class AuctionService : IAuctionService
    {
        public bool AddAuction(Auction auctionToAdd)
        {
            ControlAuction ctrlAuction = new ControlAuction();
            return ctrlAuction.InsertAuction(auctionToAdd);
        }

        public void DeleteAuction(int auctionId)
        {
            ControlAuction ctrlAuction = new ControlAuction();
            ctrlAuction.DeleteAuction(auctionId);
        }

        public Auction GetAuctionById(int findAuctionId)
        {
            ControlAuction ctrlAuction = new ControlAuction();
            return ctrlAuction.GetAuctionById(findAuctionId);
        }

        public void UpdateAuction(Auction auctionToUpdate) {
            ControlAuction ctrlAuction = new ControlAuction();
            ctrlAuction.ModifyAuction(auctionToUpdate);
        }
        public List<Auction> GetAuctionAll() {
            ControlAuction ctrlAuction = new ControlAuction();
            return ctrlAuction.GetAllAuctions();
        }
    }
}
