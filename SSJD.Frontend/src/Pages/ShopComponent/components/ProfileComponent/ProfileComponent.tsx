/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useEffect, useState } from 'react';

import './ProfileComponent.css';
import { GetUserProfileById } from '../../../../Responsitories/UserResponsitory';
import { UserOrderProfile } from '../../../../Model/User/UserOrderProfile';


const ProfileComponent:React.FC = () => {
  const [profile,setprofile] = useState<UserOrderProfile>()
  useEffect(() => {
    const fetch = async () => {
      const userId = localStorage.getItem('id');
      console.log(userId)
      if (userId) {
        const data = await GetUserProfileById(userId);
        if(data) setprofile(data);
      }
    };
    fetch();
    console.log(profile)
  });
  return(
  <div className='container'>
    <div className='profile'>
      <div className="d-flex flex-column justify-content-center align-items-center">
        <span className='content-title'>My Account</span>
        <div className='d-flex flex-column justify-content-center align-items-center gap-2'>
          <span>Welcome back, {profile?.userName}</span>
          <div>Your Points Balance : {profile?.point}</div>
        </div>
        <div>
            <button className='redeem-button'>Redeem Points</button>
        </div>
      </div>
      <div className='profile-detail'>
        <span className='content-title'>Account Details</span>
        <div className='profile-detail-infor d-flex flex-column'>
          <span>{profile?.userName}</span>
          <span>{profile?.address}</span>
        </div>
      </div>
      <div className='order-history'>
        <span className='order-history-title'>Order History</span>
        <div className='order-history-detail'>
            <span>{profile?.productName} </span>
        </div>
      </div>
    </div>
</div>
  )
}
export default ProfileComponent