/* eslint-disable @typescript-eslint/no-unused-vars */
import React from 'react';

import './ProfileComponent.css';

export interface ProfileComponentProps {
  prop?: string;
}

export function ProfileComponent({prop = 'default value'}: ProfileComponentProps) {
  return(
  <div className='container'>
    <div className='profile'>
      <div className="d-flex flex-column justify-content-center align-items-center">
        <span className='content-title'>My Account</span>
        <div className='d-flex flex-column justify-content-center align-items-center gap-2'>
          <span>Welcome back, Thanh {}</span>
          <div>Your Points Balance : {}</div>
        </div>
        <div>
            <button className='redeem-button'>Redeem Points</button>
        </div>
      </div>
      <div className='profile-detail'>
        <span className='content-title'>Account Details</span>
        <div className='profile-detail-infor d-flex flex-column'>
          <span>thanh nguyen</span>
          <span>Vietnam</span>
          <span>Address Detail</span>
        </div>
      </div>
      <div className='order-history'>
        <span className='order-history-title'>Order History</span>
        <div className='order-history-detail'>
            <span>You haven't placed any order yet  </span>
        </div>
      </div>
    </div>
</div>
  )
}
